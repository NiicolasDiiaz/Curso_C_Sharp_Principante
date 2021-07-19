using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Enter the name of the product")]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Enter the price of the product")]
        public int Price { get; set; }
        
        [Required(ErrorMessage = "Enter the manufacturer of the product")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Enter the date of entry of the product")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of entry")]
        public DateTime DateOfEntry { get; set; }
    }
}
