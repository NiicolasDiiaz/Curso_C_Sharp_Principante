using System;

namespace Seccion_11_Conceptos_Avanzados
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroMenu = Menu();
            while (numeroMenu >= 1 && numeroMenu <= 3)
            {
                SelectorMenu(ref numeroMenu);
                numeroMenu = Menu();
            }
        }

        public static int Menu()
        {
            Console.WriteLine("Ingrese el punto deseado (1-3)");
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

                default:
                    break;
            }
        }

        public static void Punto1() { }
        public static void Punto2() { }
        public static void Punto3() { }
    }
}
