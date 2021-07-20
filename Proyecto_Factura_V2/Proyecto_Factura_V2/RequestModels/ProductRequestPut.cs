using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.RequestModels
{
    public class ProductRequestPut
    {
        public int ProductId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }

        public string Manufacturer { get; set; }


        public int BranchId { get; set; }
    }
}
