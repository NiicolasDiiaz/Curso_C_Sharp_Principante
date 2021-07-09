using System;
using System.Text;

namespace Seccion6
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
            Console.WriteLine("Escribe tu nombre: ");
            String nombre = Console.ReadLine();

            if (String.Equals(nombre, "alejandro", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hola");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
        }
        public static void Punto2()
        {
            Console.WriteLine("Escribe una palabra");
            char[] palabra = Console.ReadLine().ToCharArray();
            Array.Reverse(palabra);
            Console.WriteLine(palabra);

        }
        public static void Punto3()
        {
            Console.WriteLine("Ingrese al menos 20 caracteres y 4 palabras");
            String frase = Console.ReadLine();
            var fraseSplit = frase.Split();

            if (frase.Length >= 20 && fraseSplit.Length >= 4)
            {
                Console.WriteLine(frase.Length + " de longitud");

                String fraseAXM = frase.Replace("a", "x");
                fraseAXM = fraseAXM.Replace("A", "X");
                Console.WriteLine(fraseAXM);

                Console.WriteLine(frase.ToUpper());
                Console.WriteLine(frase.ToLower());

                String frase03 = frase.Remove(0, 3);
                Console.WriteLine(frase03);

                String frase510 = frase.Substring(5, 5);
                Console.WriteLine(frase510);

                char[] fraseArray = frase.ToCharArray();
                Array.Reverse(fraseArray);
                Console.WriteLine(fraseArray);

                Console.WriteLine(fraseSplit.Length + " palabras");

                Console.WriteLine(fraseSplit[2]);
            }
            else
            {
                Console.WriteLine("Frase incorrecta");
            }


        }
        public static void Punto4()
        {
            Console.WriteLine("Escriba primer numero");
            String numero1 = Console.ReadLine();
            Console.WriteLine("Escriba segundo numero");
            String numero2 = Console.ReadLine();
            Console.WriteLine("Escriba tercer numero");
            String numero3 = Console.ReadLine();
            Console.WriteLine("Escriba cuarto numero");
            String numero4 = Console.ReadLine();

            StringBuilder sb = new StringBuilder($"El primer numero introducido es el {numero1} , despues han introducido el {numero2} y {numero3} y por ultimo el {numero4}");
            Console.WriteLine(sb);
        }
        public static void Punto5()
        {
            for (int i = 90; i >= 65; i--)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}