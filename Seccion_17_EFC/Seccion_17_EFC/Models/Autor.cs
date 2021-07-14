using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }

        public Cancion Cancion { get; set; }

    }
}
