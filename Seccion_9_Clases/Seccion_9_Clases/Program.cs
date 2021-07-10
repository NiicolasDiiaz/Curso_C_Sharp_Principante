using System;
using System.Collections.Generic;

namespace Seccion_9_Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroMenu = Menu();
            while (numeroMenu >= 1 && numeroMenu <= 6)
            {
                SelectorMenu(ref numeroMenu);
                numeroMenu = Menu();
            }
        }

        public static int Menu()
        {
            Console.WriteLine("Ingrese el punto deseado (1-6)");
            return int.Parse(Console.ReadLine());
        }
        public static void SelectorMenu(ref int numeroMenu)
        {
            switch (numeroMenu)
            {
                case 1:
                    Punto1();
                    break;

                case 2:
                    Punto2();
                    break;

                case 3:
                    Punto3();
                    break;

                case 4:
                    Punto4();
                    break;

                case 5:
                    Punto5();
                    break;

                case 6:
                    Punto6();
                    break;

                default:
                    break;
            }
        }
        public static void Punto1() 
        {
            List <Persona> peopleList = new List<Persona>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese nombre de la persona {i + 1}");
                String name = Console.ReadLine();
                Console.WriteLine($"Ingrese edad de la persona {i + 1}");
                int age = int.Parse(Console.ReadLine());

                peopleList.Add(new Persona(name, age));
            }

            foreach (var item in peopleList)
            {
                item.showInfo();
            }
        }
        public static void Punto2() { }
        public static void Punto3() { }
        public static void Punto4() { }
        public static void Punto5() { }
        public static void Punto6() { }
    }
}