using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp5EMVC.Models;
using WebApp5EMVC.Models.Entity;
using WebApp5EMVC.Models.View;
using WebApp5EMVC.Helpers;

namespace WebApp5EMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Prodotto> prodotti = DatabaseHelper.GetAllProdotti();
            var model = new IndexView
            {
                Prodotti=prodotti
            };
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            Prodotto prodotto = DatabaseHelper.GetProdottoByID(id);
            //prodotto.Immagine = $"/Uploads/Prodotti/Imgs/{prodotto.Id}/{prodotto.Immagine}";
            var model = new DetailView
            {
                Prodotto = prodotto
            };
            if (prodotto == null)
            {
                model.MessaggioErrore = "Prodotto non esistente";
                ViewBag.Title = "Errore";
            }
            else
            {
                ViewBag.Title = prodotto.Nome;
            }
            return View(model);
        }
    }
}
