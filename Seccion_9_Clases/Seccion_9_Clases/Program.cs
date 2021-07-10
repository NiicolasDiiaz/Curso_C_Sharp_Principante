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
        public static void Punto2() 
        {
            List<Profesor> teachers = new List<Profesor>();
            List<Alumno> students = new List<Alumno>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese nombre de la persona {i + 1}");
                String name = Console.ReadLine();
                Console.WriteLine($"Ingrese edad de la persona {i + 1}");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese si la persona {i + 1} es alumno o profesor");
                string position = Console.ReadLine();

                switch (position)
                {
                    case "alumno":
                        Console.WriteLine($"Ingrese identificacion de la persona {i + 1}");
                        students.Add(new Alumno(name, age, int.Parse(Console.ReadLine())));
                        break;

                    case "profesor":
                        Console.WriteLine($"Ingrese materia que imparte la persona {i + 1}");
                        teachers.Add(new Profesor(name, age, Console.ReadLine()));
                        break;

                    default:
                        break;
                }
            }

            foreach (var item in teachers)
            {
                item.showProfe();
            }
            foreach (var item in students)
            {
                item.showAlumno();
            }
        }
        public static void Punto3() 
        {
            Coche car = new Coche();
            car.sayName();
            car.transportWay();
            Console.WriteLine();
            Avion airplane = new Avion();
            airplane.sayName();
            airplane.transportWay();
            Console.WriteLine();
            Barco ship = new Barco();
            ship.sayName();
            ship.transportWay();
            Console.WriteLine();
        }
        public static void Punto4() { }
        public static void Punto5() { }
        public static void Punto6() { }
    }
}