using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HotelDemo.Models
{
    public class Soba
    {
        [Key]
        public int Sobe_ID { get; set; }

        public string Sprat { get; set; }
        public string Pogled { get; set; }

        [Display(Name = "Broj sobe")]
        public int Broj_Sobe { get; set; }

        [Display(Name = "Tip sobe")]
        public string Tip_Sobe { get; set; }

        [Display(Name = "Zauzece sobe")]
        public bool Stanje_Sobe { get; set; }
    }
}