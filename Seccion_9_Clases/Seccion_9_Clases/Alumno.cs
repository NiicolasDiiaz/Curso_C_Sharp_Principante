using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_9_Clases
{
    class Alumno : Persona
    {
        public int id { get; set; }

        public Alumno()
        {
            nombre = "";
            edad = 0;
            id = 0;
        }

        public Alumno(string name, int age, int  id)
        {
            nombre = name;
            edad = age;
            this.id = id;
        }
        public void showAlumno()
        {
            Console.WriteLine($"El nombre es: {nombre}, la edad es: {edad} y su codigo es: {id}");
        }
    }
}
