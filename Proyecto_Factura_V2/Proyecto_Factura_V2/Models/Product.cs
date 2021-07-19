using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Enter the name of the product")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Enter the price of the product")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Enter the manufacturer of the product")]
        public string Manufacturer { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of entry")]
        public DateTime DateOfEntry { get; set; }


        public Branch Branch { get; set; }
        public int BranchId { get; set; }
    }
}
