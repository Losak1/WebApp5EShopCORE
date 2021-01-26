using System;
namespace WebApp5EMVC.Models.Entity
{
    public class Prodotto:BaseEntity
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Immagine { get; set; }
        public double Prezzo { get; set; }
        public int Quantita { get; set; }
    }
}