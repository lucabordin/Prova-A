using System.ComponentModel.DataAnnotations;

namespace WebAPIFaseA.Entities
{
    public class Carrello
    {
        [Key]
        public int IdCarrello { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdProdotto { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double PrezzoProdotto { get; set; }
        [Required]
        public int QuantitaProdotto { get; set; }
    }
}
