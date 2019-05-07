using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelDemo.Models;

namespace HotelDemo.Controllers
{
    public class GostController : Controller
    {
        private ApplicationDbContext _context;

        public GostController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Gost
        public ActionResult Index()
        {


            IEnumerable<Gost> gosti = _context.Gosti.ToList();


            return View(gosti);
        }

        public ActionResult Details(int id)
        {

            var gost = _context.Gosti.SingleOrDefault(c => c.Gost_ID == id);

            if (gost == null)
                return HttpNotFound();
            
            return View(gost);
        }
    }
}