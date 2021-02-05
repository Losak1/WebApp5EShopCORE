using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp5EMVC.Models.View;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp5EMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult SignUp()
        {
            var model = new SignUpViewModel();
            SetSignUpViewModelLabels(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            if(model.Password==null){   //Potenziare i controlli, spostare la logica in un altro punto
                model.Errore = "Valorizzare tutti i campi!";
            }
             
            SetSignUpViewModelLabels(model);
            return View(model);
        }

        private void SetSignUpViewModelLabels(SignUpViewModel model)
        {
            ViewBag.Title = model.LabelTitolo = "Sign Up";
            model.LabelBottone = "Registrati";
            model.LabelEmail = "Email";
            model.LabelPassword = "Password";
            model.LabelConfermaPassword = "Conferma password";
            model.LabelNome = "Nome";
        }
    }
}
