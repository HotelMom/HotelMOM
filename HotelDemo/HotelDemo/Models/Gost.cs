using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HotelDemo.Models
{
    public class Gost
    {
        [Key]
        public int Gost_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Ime { get; set; }

        public string Prezime { get; set; }

        [Required]
        public string Broj_LK_Pasos { get; set; }

        public Placanje Placanje { get; set; }

        public int PlacanjeId { get; set; }

        

    }
}