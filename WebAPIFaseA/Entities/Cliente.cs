using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebAPIFaseA.Entities
{
    public class Cliente
    {

        /*clienti : Nome, Cognome, Data di nascita, Email, Password
    i campi tutti obbligatori
    mail xxx @xx.xx
    età >=18
    password 12 caratteri : 3 maiuscole, 4 numeri, 3 minuscole, 2 caratteri tra @#!&%
	
         */
        
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [Range(typeof(DateTime), "01/01/1900", "31/12/2005", ErrorMessage = "Il cliente deve essere maggiorenne.")]
        public DateTime DataDiNascita { get; set; }
        
        [EmailAddress]
        public string Email { get; set;}

        [StringLength(12)]
        [RegularExpression(@"^(?=(.*[A-Z]){3})(?=(.*[0-9]){4})(?=(.*[a-z]){3})(?=(.*[@#!&%]){2})")]
        public string Password { get; set;} 
       

    }
}
