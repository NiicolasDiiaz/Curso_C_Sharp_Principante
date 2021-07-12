using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_13_Archivos_y_Streams
{
    class Persona
    {
        public string name { get; set; }
        public int age { get; set; }
        public string location { get; set; }

        public string InsertPerson()
        {
            return name + "|" + age.ToString() + "|" + location + ";";
        }
    }
}
