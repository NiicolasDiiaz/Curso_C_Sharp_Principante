using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_11_Conceptos_Avanzados
{
    class Animal
    {
        public string tipo { get; set; }

        public void identAnimal(animales entrada)
        {
            switch (entrada)
            {
                case animales.perro:
                    tipo = "Perro";
                    break;
                case animales.gato:
                    tipo = "Gato";
                    break;
                case animales.canario:
                    tipo = "Canario";
                    break;
                case animales.caballo:
                    tipo = "Caballo";
                    break;
                default:
                    break;
            }
        }
    }
}
