using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HotelDemo.Models
{
    public class Placanje
    {
        [Key]
        public int Placanje_ID { get; set; }

        public string NacinPlacanja { get; set; }

        public decimal Iznos { get; set; }

        
       
       

    }
}