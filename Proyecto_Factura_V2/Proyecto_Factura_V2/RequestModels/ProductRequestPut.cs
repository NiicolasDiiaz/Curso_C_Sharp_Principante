using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.RequestModels
{
    public class ProductRequestPut
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Enter the name of the product")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter the price of the product")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Enter the manufacturer of the product")]
        public string Manufacturer { get; set; }


        public int BranchId { get; set; }
    }
}
