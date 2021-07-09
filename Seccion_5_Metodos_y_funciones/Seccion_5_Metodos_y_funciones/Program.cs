using System;
using System.Collections.Generic;
using System.Linq;

namespace Seccion5
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
            Console.WriteLine("Escriba tipo de cambio:");
            float tipoDeCambio = float.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor a convertir:");
            float valorAConvertir = float.Parse(Console.ReadLine());

            float valorConvertido = valorAConvertir * tipoDeCambio;
            Console.WriteLine("El valor convertido es de: " + valorConvertido);
        }
        public static void Punto2()
        {
            int numeroSelectorCalculadora = MenuCalculadora();
            Console.WriteLine("Ingrese primer numero:");
            double primerNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero:");
            double segundoNumero = double.Parse(Console.ReadLine());

            switch (numeroSelectorCalculadora)
            {
                case 1:
                    Console.WriteLine("El resultado es: " + Suma(primerNumero, segundoNumero));
                    break;

                case 2:
                    Console.WriteLine("El resultado es: " + Resta(primerNumero, segundoNumero));
                    break;

                case 3:
                    Console.WriteLine("El resultado es: " + Multiplicacion(primerNumero, segundoNumero));
                    break;

                case 4:
                    Console.WriteLine("El resultado es: " + Division(primerNumero, segundoNumero));
                    break;

                default:
                    break;
            }


            static int MenuCalculadora()
            {
                Console.WriteLine("1- Suma");
                Console.WriteLine("2- Resta");
                Console.WriteLine("3- Multiplicacion");
                Console.WriteLine("4- Division");

                return int.Parse(Console.ReadLine());
            }
            static double Suma(double numero1, double numero2)
            {
                return (numero1 + numero2);
            }
            static double Resta(double numero1, double numero2)
            {
                return (numero1 - numero2);
            }
            static double Multiplicacion(double numero1, double numero2)
            {
                return (numero1 * numero2);
            }
            static double Division(double numero1, double numero2)
            {
                return (numero1 / numero2);
            }
        }
        public static void Punto3()
        {
            double[] valoresBilletes = new double[] { 100000, 50000, 20000, 10000, 5000, 2000, 1000 };
            double[] valoresMonedas = new double[] { 500, 200, 100, 50 };
            Console.WriteLine("Ingrese importe:");
            int importeInicial = int.Parse(Console.ReadLine());

            double importe = importeInicial;
            Console.WriteLine(CalcularBilletes(ref importe, valoresBilletes) + " billetes");
            Console.WriteLine(CalcularMonedas(ref importe, valoresMonedas) + " monedas");
            Console.WriteLine(importe + " restante");
            //CalcularMonedas(ref importe);

            static double CalcularBilletes(ref double importe, double[] valoresMoneda)
            {
                double[] numeroBilletes = new double[7] { 0, 0, 0, 0, 0, 0, 0 };

                for (int iBilletes = 0; importe >= valoresMoneda[valoresMoneda.Length - 1]; iBilletes++)
                {
                    numeroBilletes[iBilletes] += Math.Floor(importe / valoresMoneda[iBilletes]);
                    importe -= numeroBilletes[iBilletes] * valoresMoneda[iBilletes];
                }

                return numeroBilletes.Sum();
            }
            static double CalcularMonedas(ref double importe, double[] valoresMoneda)
            {
                double[] numeroMonedas = new double[4] { 0, 0, 0, 0 };

                for (int iMonedas = 0; importe >= valoresMoneda[valoresMoneda.Length - 1]; iMonedas++)
                {
                    numeroMonedas[iMonedas] += Math.Floor(importe / valoresMoneda[iMonedas]);
                    importe -= numeroMonedas[iMonedas] * valoresMoneda[iMonedas];
                }

                return numeroMonedas.Sum();
            }

        }
        public static void Punto4()
        {
            Console.WriteLine("Introduza una letra o numero");
            char letraNumero = Console.ReadKey().KeyChar;

            if (EsNumero(letraNumero))
            {
                Console.WriteLine(" Es numero!");
            }
            else if (EsVocal(letraNumero))
            {
                Console.WriteLine(" Es vocal!");
            }
            else
            {
                Console.WriteLine(" Es consonante");
            }

            static bool EsNumero(char letraNumero)
            {
                return char.IsNumber(letraNumero);
            }
            static bool EsVocal(char letraNumero)
            {
                if (letraNumero == 'a' || letraNumero == 'e' || letraNumero == 'i' || letraNumero == 'o' || letraNumero == 'u')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void Punto5()
        {
            Console.WriteLine("Ingrese un numero:");
            int numeroUsuario = int.Parse(Console.ReadLine());
            tablaMultiplicar(numeroUsuario);

            static void tablaMultiplicar(int numero)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(numero + " * " + i + " = " + (numero * i));
                }
            }
        }
        public static void Punto6()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingrese un numero distinto a cero");
            int numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {

                numeros.Add(numero);
                Console.WriteLine("Ingrese un numero distinto a cero");
                numero = int.Parse(Console.ReadLine());

            }


            Console.WriteLine("El mayor es: " + numeros.Max());
            Console.WriteLine("El menor es: " + numeros.Min());
            Console.WriteLine("Diferencia entre mayor y menor es: " + (numeros.Max() - numeros.Min()));
            Console.WriteLine("El numero total de elementos es: " + numeros.Count);

        }
    }
}