using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_10_Interfaces
{
    class Animal : IAnimal
    {
        public void Andar()
        {
            Console.WriteLine("Estoy andando");
        }

        public void EsPerro()
        {
            Console.WriteLine("Gauuuuuuuuuuuuuuu");
        }

        public void Saltar()
        {
            Console.WriteLine("Estoy saltando!");
        }
    }
}
