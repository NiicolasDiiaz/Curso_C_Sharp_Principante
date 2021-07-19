using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.ViewModels
{
    public class ProductViewModel
    {
        //Model for the user to watch at
        //This model tends to be a reduced model of the original model in folder "Models"
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

    }
}
