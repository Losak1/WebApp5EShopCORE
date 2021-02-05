using System;
namespace WebApp5EMVC.Models.View
{
    public class SignUpViewModel
    {
        public string LabelTitolo { get; set; }
        public string LabelBottone { get; set; }
        public string LabelEmail { get; set; }
        public string LabelPassword { get; set; }
        public string LabelConfermaPassword { get; set; }
        public string LabelNome { get; set; }

        public string Errore { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfermaPassword { get; set; }
        public string Nome { get; set; }
    }
}
