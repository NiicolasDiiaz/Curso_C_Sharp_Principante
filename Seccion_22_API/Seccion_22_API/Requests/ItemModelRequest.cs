using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_22_API.Requests
{
    public class ItemModelRequest
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
    }
}
