using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp5EMVC.Models.Entity
{
    public class Utente:BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Range( typeof(bool), "true", "true", ErrorMessage="È necessario accettare la privacy")]
        public bool IsPrivacy { get; set; }
    } 
}
