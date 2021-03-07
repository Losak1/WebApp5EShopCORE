using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp5EMVC.Models.View
{
    public class LogInViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string LabelEmail { get; set; }
        public string LabelPassword { get; set; }
        public string LabelBottone { get; set; }
        public string LabelTitolo { get; set; }

        public bool IsSuccesso { get; set; }
        public string Messaggio { get; set; }
    }
}
 