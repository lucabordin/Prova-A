using System.ComponentModel.DataAnnotations;

namespace WebAPIFaseA.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public DateTime DataDiNascita { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Passward { get; set; }
    }
}
