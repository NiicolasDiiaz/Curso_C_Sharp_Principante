using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_9_Clases
{
    class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }

        public Persona()
        {
            nombre = "";
            edad = 0;
        }

        public Persona(string name, int age)
        {
            nombre = name;
            edad = age;
        }

        public void showInfo()
        {
            Console.WriteLine($"El nombre es: {nombre} y la edad es: {edad}");
        }

    }

}
