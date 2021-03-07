using System;
using System.ComponentModel.DataAnnotations;
using WebApp5EMVC.Models.Entity;

namespace WebApp5EMVC.Models.View
{
    public class IndexARViewModel
    {
        public string LabelTitolo { get; set; }
        public string LabelBottone { get; set; }
        public string LabelEmail { get; set; }
        public string LabelPassword { get; set; }
        public string LabelConfermaPassword { get; set; }
        public string LabelNome { get; set; }

        public string Messaggio { get; set; }
        public bool IsSuccesso { get; set; }

        public Utente Utente { get; set; }

        public string Password { get; set; }
        [Compare("Password")]
        public string ConfermaPassword { get; set; }
    }
}
