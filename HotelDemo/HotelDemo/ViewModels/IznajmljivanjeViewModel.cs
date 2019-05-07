using HotelDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelDemo.ViewModels
{
    public class IznajmljivanjeViewModel
    {
        
        public IEnumerable<Iznajmljivanje> Iznajmljivanjes { get; set; }
        public IEnumerable<Soba> Sobas { get; set; }
        public IEnumerable<Gost> Gosts { get; set; }
    }
}