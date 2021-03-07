using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp5EMVC.Helpers;
using WebApp5EMVC.Models.Entity;
using WebApp5EMVC.Models.View;
namespace WebApp5EMVC.Controllers
{
    public class AreaRisrvataController : Controller
    {
        [HttpGet]
        public ActionResult Index(IndexARViewModel model)
        {
            SetIndexARViewModelLabels(model);

            return View(model);
        }

        private void SetIndexARViewModelLabels(IndexARViewModel model)
        {
            ViewBag.Title = model.LabelTitolo = "Area riservata";
            model.LabelBottone = "Aggiorna";
            model.LabelEmail = "Email";
            model.LabelPassword = "Password";
            model.LabelConfermaPassword = "Conferma password";
            model.LabelNome = "Nome";
        }
    }
}
