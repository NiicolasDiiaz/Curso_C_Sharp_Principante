using System;
using System.IO;
using System.Text;

namespace Seccion_13_Archivos_y_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "registro.txt";
            string total = "";

            do
            {
                Persona person = new Persona();
                Menu(person);
                total += person.InsertPerson();
                Console.WriteLine("¿Desea introducir mas personas (S/N)?");
            } while (Console.ReadLine() != "N");

            EscribirArchivo(fileName, total);

            try
            {
                LeerArchivo(fileName);
            }
            catch (Exception)
            {

                Console.WriteLine("Rectifique que sus datos estan bien escritos");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Estos fueron los datos ingresados: " + total);
            }

        }
        public static void Menu(Persona person)
        {
            Console.WriteLine("Ingrese nombre de la persona");
            person.name = Console.ReadLine();
            Console.WriteLine("Ingrese edad de la persona");
            person.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese localidad de la persona");
            person.location = Console.ReadLine();
        }
        public static void EscribirArchivo(string fileName, string total)
        {
            FileStream fsWrite = new FileStream(fileName, FileMode.Append);
            fsWrite.Write(ASCIIEncoding.ASCII.GetBytes(total), 0, total.Length);
            fsWrite.Close();
        }
        public static void LeerArchivo(string fileName)
        {
            
            FileStream fsRead = new FileStream(fileName, FileMode.Open);
            
            byte[] readByte = new byte[fsRead.Length];
            fsRead.Read(readByte, 0, readByte.Length);

            string lectura = ASCIIEncoding.ASCII.GetString(readByte);
            char[] separadores = new char[] { ';', '|' };
            string[] paraMostrar = lectura.Split(separadores[0]);
            foreach (var item in paraMostrar)
            {
                string[] finalMostrar = item.Split(separadores[1]);
                foreach (var item2 in finalMostrar)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
            fsRead.Close();
        }
    }
}
