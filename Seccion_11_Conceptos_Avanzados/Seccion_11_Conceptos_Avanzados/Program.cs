using System;
using System.Collections.Generic;

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

        public static void Punto1() 
        {
            Dictionary<int, String> diccionario = new Dictionary<int, string>();
            Console.WriteLine("Ingrese un numero y una cadena por cada intro, respectivamente");
            int clave = int.Parse(Console.ReadLine());
            string valor = Console.ReadLine();

            while (clave != 0)
            {
                diccionario.Add(clave, valor);
                Console.WriteLine("Ingrese un numero y una cadena por cada intro, respectivamente");
                clave = int.Parse(Console.ReadLine());
                valor = Console.ReadLine();
            }
            Console.WriteLine("Ingrese una cadena de 2 letras");
            string palabraBusqueda = Console.ReadLine();

            foreach (var item in diccionario)
            {
                if (item.Value.Contains(palabraBusqueda))
                {
                    Console.WriteLine("La key es: " + item.Key.ToString());
                }
            }
        }
        public static void Punto2() 
        {
            ListaTotal<string> listaString = new ListaTotal<string>();

            Console.WriteLine("ingrese 3 strings separados por intro");
            for (int i = 0; i < 3; i++)
            {
                listaString.Anadir(Console.ReadLine());
            };
            Console.WriteLine();
            foreach (var item in listaString.ObtenerLista())
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("ingrese 3 enteros separados por intro");
            ListaTotal<int> listaInt = new ListaTotal<int>();
            for (int i = 0; i < 3; i++)
            {
                listaInt.Anadir(int.Parse(Console.ReadLine()));
            };
            Console.WriteLine();
            foreach (var item in listaInt.ObtenerLista())
            {
                Console.WriteLine(item);
            }
        }
        public static void Punto3() 
        {
            Animal userAnimal = new Animal();
            Console.WriteLine("Ingrese un numero");
            int numeroUser = int.Parse(Console.ReadLine());

            animales userAnimales = (animales)numeroUser;
            userAnimal.identAnimal(userAnimales);
            Console.WriteLine("Ese valor pertenece al: " + userAnimal.tipo);
            
        }
    }
}
