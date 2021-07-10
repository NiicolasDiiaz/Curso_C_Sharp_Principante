using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_9_Clases
{
    class Profesor : Persona
    {
        public string materia { get; set; }

        public Profesor()
        {
            nombre = "";
            edad = 0;
            materia = "";
        }

        public Profesor(string name, int age, string subject)
        {
            nombre = name;
            edad = age;
            materia = subject; 
        }

        public void showProfe()
        {
            Console.WriteLine($"El nombre es: {nombre}, la edad es: {edad} y la materia que imparte es: {materia}");
        }
    }
}
