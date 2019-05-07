using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelDemo.Models
{
    public class Iznajmljivanje
    {
       
        public int Id { get; set; }

        
        public Gost Gost { get; set; }
        
        [Required]
        public int GostId { get; set; }

        public Soba Soba { get; set; }
        [Required]
        public int SobaId { get; set; }

        
    }
}