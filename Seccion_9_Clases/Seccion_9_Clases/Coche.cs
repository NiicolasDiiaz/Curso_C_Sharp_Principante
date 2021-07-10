using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_9_Clases
{
    class Coche : Vehiculo
    {
        public override void sayName()
        {
            Console.WriteLine("Soy un coche");
        }

        public override void transportWay()
        {
            Console.WriteLine("Voy por la tierra");
        }
    }
}
