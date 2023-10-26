using System.ComponentModel.DataAnnotations;

namespace WebAPIFaseA.Entities
{
    public class Carrello
    {

        public int Id { get; set; }
        public int IdentificativoCliente { get; set; }
        public int IdentificativoProdotto { get; set; }
        [Required]
        public int Quantità { get; set; }
        [Required]
        public decimal Prezzo { get; set; }

    }
}
