using System;
using System.Collections.Generic;
using System.Linq;

namespace Seccion7
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroMenu = Menu();
            while (numeroMenu >= 1 && numeroMenu <= 5)
            {
                SelectorMenu(ref numeroMenu);
                numeroMenu = Menu();
            }
        }

        public static int Menu()
        {
            Console.WriteLine("Ingrese el punto deseado (1-5)");
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

                default:
                    break;
            }
        }

        public static void Punto1()
        {
            List<int> lista = new List<int>();

            for (int i = 1; i <= 1000; i++)
            {
                lista.Add(i);
            }
            int suma = 0;
            foreach (var item in lista)
            {
                suma += item;
                Console.WriteLine(suma);
            }
        }
        public static void Punto2()
        {
            List<String> listaNombres = new List<String>();

            Console.WriteLine("Escriba el nombre 1:");
            listaNombres.Add(Console.ReadLine());
            Console.WriteLine("Escriba el nombre 2:");
            listaNombres.Add(Console.ReadLine());
            Console.WriteLine("Escriba el nombre 3:");
            listaNombres.Add(Console.ReadLine());
            Console.WriteLine("Escriba el nombre 4:");
            listaNombres.Add(Console.ReadLine());
            Console.WriteLine("Escriba el nombre 5:");
            listaNombres.Add(Console.ReadLine());

            Console.WriteLine("introduzca el nombre a encontrar:");
            String nombreEncontrar = Console.ReadLine();

            if (listaNombres.Contains(nombreEncontrar))
            {
                Console.WriteLine("Esta en lista");
            }
            else
            {
                Console.WriteLine("NO esta en lista");
            }


        }
        public static void Punto3()
        {
            List<int> lista3 = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                lista3.Add(int.Parse(Console.ReadLine()));
            }

            List<int> lista3Pares = new List<int>();
            List<int> lista3Impares = new List<int>();

            foreach (var item in lista3)
            {
                if (item % 2 == 0)
                {
                    lista3Pares.Add(item);
                }
                else
                {
                    lista3Impares.Add(item);
                }
            }
            Console.WriteLine("La suma de los pares es: " + lista3Pares.Sum());
            Console.WriteLine("La suma de los impares es: " + lista3Impares.Sum());

        }
        public static void Punto4()
        {
            List<int> lista4 = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                lista4.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("El numero mayor es:" + lista4.Max());
            Console.WriteLine("El numero menor es:" + lista4.Min());
        }
        public static void Punto5()
        {
            List<int> lista5 = new List<int>();
            Console.WriteLine("Ingrese numero de datos a añadir:");
            int numeroDatos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDatos; i++)
            {
                Console.WriteLine("Ingrese un numero");
                lista5.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Ingrese valor a añadir:");
            int valorAnadir = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese posicion del valor a añadir:");
            int posValor = int.Parse(Console.ReadLine());

            lista5.Insert(posValor, valorAnadir);

            foreach (var item in lista5)
            {
                Console.WriteLine(item);
            }
        }

    }
}