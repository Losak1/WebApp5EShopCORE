using System;
using WebApp5EMVC.Models.Entity;
namespace WebApp5EMVC.Models.View
{
    public class DetailViewModel
    {
        public string QuantitaLabel { get; set; }

        public Prodotto Prodotto { get; set; }
        public string MessaggioErrore { get; set; }
    }
}
 