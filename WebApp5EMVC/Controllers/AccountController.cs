using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp5EMVC.Helpers;
using WebApp5EMVC.Models.Entity;
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
                model.Utente.Password = string.Empty;
                var id = DatabaseHelper.InsertUtente(model.Utente);
                if (id > 0)
                {
                    model.Utente.Password = CryptoHelper.HashSHA256(model.Password + id);
                    var result = DatabaseHelper.UpdatePassword(id, model.Utente.Password);
                    if (result)
                    {
                        //Inviare mail
                    }
                }
                model.Messaggio = $"Iscrizione avvenuta con successo. Registrato con id {id}";
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

        [HttpGet]
        public IActionResult LogIn()
        {
            var model = new LogInViewModel();
            SetLogInViewModelLabels(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult LogIn(LogInViewModel model)
        {
            SetLogInViewModelLabels(model);
            if (!ModelState.IsValid)
            {
                model.Messaggio = "Completa correttamente tutti i campi!";
                model.IsSuccesso = false;
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        model.Messaggio += "<br>" + error.ErrorMessage;
                    }
                }
                return View(model);
            }
            
            Utente utente = DatabaseHelper.GetUtenteByEmail(model.Email);
            if (utente == null || CryptoHelper.HashSHA256(model.Password + utente.Id) != utente.Password)
            {
                model.Messaggio = "Email o password incoretti.";
                model.IsSuccesso = false;
                return View(model);
            }

            model.Messaggio = $"Accesso effettuato!.";
            model.IsSuccesso = true;
            return View(model); //redirect quando sarà pronta l'action
        }

        private void SetLogInViewModelLabels(LogInViewModel model)
        {
            ViewBag.Title = model.LabelTitolo = "Log In";
            model.LabelBottone = "Accedi";
            model.LabelEmail = "Email";
            model.LabelPassword = "Password";
        }
    }
}
