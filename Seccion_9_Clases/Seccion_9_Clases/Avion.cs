using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_9_Clases
{
    class Avion : Vehiculo
    {
        public override void sayName()
        {
            Console.WriteLine("Soy un avion");
        }

        public override void transportWay()
        {
            Console.WriteLine("Voy por el aire");
        }
    }
}
