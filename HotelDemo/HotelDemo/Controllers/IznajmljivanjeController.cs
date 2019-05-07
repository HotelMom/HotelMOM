using HotelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelDemo.ViewModels;

namespace HotelDemo.Controllers
{
    public class IznajmljivanjeController : Controller
    {

        private ApplicationDbContext _context;
        public IznajmljivanjeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: Iznajmljivanje
        public ActionResult Index()
        {
            return View();
        }


        // novi
        public ActionResult Novi()
        {
            var izViewModel = new IznajmljivanjeViewModel();
            var zauzetiGostId = from gost in _context.Iznajmljivanja
                                select gost.Id;
            //var zauzetiList = zauzetiGostId.ToList();
            var slobodniGosti = from gost in _context.Gosti
                                where !zauzetiGostId.Contains(gost.Gost_ID)
                                select gost;
            //var slobodniList = slobodniGosti.ToList();
              izViewModel.Gosts = slobodniGosti.ToList();
              izViewModel.Sobas = _context.Sobe.ToList();


            return View(izViewModel);
        }

        
        public ActionResult Zauzete()
        {
            var zauzViewModel = new IznajmljivanjeViewModel();

            var iznajmljivanjaId = from iznajm in _context.Iznajmljivanja
                                   select iznajm.Id;
            var tempIznajmId = iznajmljivanjaId.ToList();

            var iznajmljivanjaIdOrg = from iznajm in _context.Iznajmljivanja
                                   select iznajm;
            var iznajmljivanjaIdOrgList = iznajmljivanjaIdOrg.ToList();


            var iznajmGostiIme = from gost in _context.Gosti
                                 where tempIznajmId.Contains(gost.Gost_ID)
                                 select gost;
            var tempIznajmGostIme = iznajmGostiIme.ToList();


            var iznajmSobaId = from soba in _context.Sobe
                                 where tempIznajmId.Contains(soba.Sobe_ID)
                                 select soba;
            var tempIznajmSobaId = iznajmSobaId.ToList();




            zauzViewModel.Iznajmljivanjes = iznajmljivanjaIdOrgList;
            zauzViewModel.Gosts = tempIznajmGostIme;
            zauzViewModel.Sobas = tempIznajmSobaId;



            




            return View(zauzViewModel);
        }
    }
}