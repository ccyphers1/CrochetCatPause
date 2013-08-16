using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrochetCatPause.Models
{
    public class UpcomingShow
    {
        public int ID { get; set; }

        [Required]
        public DateTime ShowDate { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(30)]
        public string Venue { get; set; }
    }
}