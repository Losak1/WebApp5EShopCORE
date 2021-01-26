using System;
namespace WebApp5EMVC.Models.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Creazione { get; set; }
        public DateTime? Modifica { get; set; }
    }
}
