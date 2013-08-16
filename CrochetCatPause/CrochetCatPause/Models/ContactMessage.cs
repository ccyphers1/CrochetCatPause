using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrochetCatPause.Models
{
    public class ContactMessage
    {
        [Required(ErrorMessage = "Gotta give yur name")]
        [StringLength(32)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Emails are needed")]
        [EmailAddress]
        public string ReturnEmail { get; set; }

        [StringLength(32)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "You gotta say something...")]
        [StringLength(1048)]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}