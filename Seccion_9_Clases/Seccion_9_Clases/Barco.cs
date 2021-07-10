using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_9_Clases
{
    class Barco : Vehiculo
    {
        public override void sayName()
        {
            Console.WriteLine("Soy un barco");
        }

        public override void transportWay()
        {
            Console.WriteLine("Voy por el agua");
        }
    }
}
