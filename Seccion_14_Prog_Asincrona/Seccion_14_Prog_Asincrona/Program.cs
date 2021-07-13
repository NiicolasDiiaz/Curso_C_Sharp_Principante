using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Seccion_14_Prog_Asincrona
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task<Agua> aguaTask = ServirAgua(1);
            Task<Guiso> guisoTask = PrepararGuiso(1);
            Task<Huevos> huevosTask = PrepararHuevos(3);
            Task<Papas> papasTask = PrepararPapas(2);

            List<Task> allTasks = new List<Task> { aguaTask, guisoTask, huevosTask, papasTask };

            Agua water = new Agua();
            Guiso sauce = new Guiso();
            Huevos eggs = new Huevos();
            Papas potatoes = new Papas();

            while (allTasks.Count > 0)
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished==aguaTask)
                {
                    water = await aguaTask;
                    allTasks.Remove(aguaTask);
                    Console.WriteLine("El agua esta servida");
                }
                else if(finished == guisoTask)
                {
                    sauce = await guisoTask;
                    allTasks.Remove(guisoTask);
                    Console.WriteLine("El guiso esta listo");
                }
                else if (finished == huevosTask)
                {
                    eggs = await huevosTask;
                    allTasks.Remove(huevosTask);
                    Console.WriteLine("Los huevos estan listos");
                }
                else if (finished == papasTask)
                {
                    potatoes = await papasTask;
                    allTasks.Remove(papasTask);
                    Console.WriteLine("Las papas estan listas");
                }
            }

            MezclarYFreirTodo(potatoes, sauce, eggs);
            Console.WriteLine("TORTILLA FINALIZDA");


        }

        public static async Task<Agua> ServirAgua(int cantidad)
        {
            return new Agua();
        }
        public static async Task<Huevos> PrepararHuevos(int cantidad)
        {
            return new Huevos();
        }
        public static async Task<Guiso> PrepararGuiso(int cantidad)
        {
            return new Guiso();
        }
        public static async Task<Papas> PrepararPapas(int cantidad)
        {
            return new Papas();
        }
        public static void MezclarYFreirTodo(Papas potatoes, Guiso sauce, Huevos eggs)
        {

        }


    }
}
