using System.ComponentModel.DataAnnotations;

namespace WebAPIFaseA.DTO
{
    public class RestituisciClienteDto
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public string Email { get; set; }
    }
}
