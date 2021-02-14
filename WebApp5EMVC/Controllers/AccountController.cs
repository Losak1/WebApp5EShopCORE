using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp5EMVC.Helpers;
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
            ModelState.Remove("Utente.password");
            SetSignUpViewModelLabels(model);
            model.Utente.Password = model.Password;
            if (ModelState.IsValid)
            {
                //Commentato in quanto il controllo è gestito dalla data annotation
                /*if (!model.Utente.IsPrivacy)
                {
                    model.Messaggio = "È necessario accettare la privacy";
                    model.IsSuccesso = false;
                    return View(model);
                }*/
                if (DatabaseHelper.ExistsEmail(model.Utente.Email))
                {
                    model.Messaggio = "Esiste già un account con questa email!";
                    model.IsSuccesso = false;
                    return View(model);
                }
                //TODO salvare su db e altri controlli
                var res = DatabaseHelper.InsertUtente(model.Utente);
                model.Messaggio = $"Iscrizione avvenuta con successo. Registrato con id {res}";
                model.IsSuccesso = true;
            } else
            {
                model.Messaggio = "Completa correttamente tutti i campi!";
                model.IsSuccesso = false;
                foreach(var value in ModelState.Values)
                {
                    foreach(var error in value.Errors)
                    {
                        model.Messaggio += "<br>" + error.ErrorMessage;
                    }
                }
                
            }
             
            
            
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
            model.LabelPrivacy = "Accetto condizioni privacy";
        }
    }
}
