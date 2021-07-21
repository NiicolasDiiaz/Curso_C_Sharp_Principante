using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Enter the first name of the customer")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter the last name of the customer")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter the cellphone of the customer")]
        public int Cellphone { get; set; }

        public string HomeAddress { get; set; }

        public string EmailAddress { get; set; }
    }
}
