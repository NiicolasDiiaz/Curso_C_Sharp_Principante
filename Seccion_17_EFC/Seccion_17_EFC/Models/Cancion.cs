using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.Models
{
    public class Cancion
    {
        public int CancionId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan Duracion { get; set; }

        public Album Album { get; set; }
        public int AlbumId { get; set; }
        public Autor Autor { get; set; }
        public int AutorId { get; set; }
    }
}
