using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrochetCatPause.Models
{
    public class BlogPost
    {
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Title { get; set; }

        [Required]
        [StringLength(25)]
        public string Author { get; set; }

        public DateTime PostTime { get; set; }

        [Required]
        public string Content { get; set; }

        public bool Published { get; set; }
    }
}