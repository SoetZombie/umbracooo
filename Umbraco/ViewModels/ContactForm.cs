using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Umbraco.ViewModels
{
    public class ContactForm
    {
        [Required( ErrorMessage ="Please provide name")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Please provide email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please provide Message")]
        public string Message { get; set; }
    }
}