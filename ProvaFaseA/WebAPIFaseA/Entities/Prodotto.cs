using System.ComponentModel.DataAnnotations;

namespace WebAPIFaseA.Entities
{
    public class Prodotto
    {
        [Key]
        public int IdProdotto { get; set; }
        [Required]
        public string Nome { get; set; }
        [DataType(DataType.Currency)]
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }
    }
}
