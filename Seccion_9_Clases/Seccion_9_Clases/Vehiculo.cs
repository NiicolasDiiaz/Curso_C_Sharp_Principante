using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_9_Clases
{
    public class Vehiculo
    {
        private int _ruedas { get; set; }
        private int _puertas { get; set; }

        public Vehiculo()
        {
            _ruedas = 0;
            _puertas = 0;
        }

        public Vehiculo(int puertas)
        {
            _puertas = puertas;
            _ruedas = 0;
        }

        public Vehiculo(int puertas, int ruedas)
        {
            _ruedas = ruedas;
            _puertas = puertas;
        }

        public void getVehiculoInfo()
        {
            Console.WriteLine($"Tengo {_puertas} puertas y {_ruedas} ruedas");
        }
        public virtual void transportWay()
        {

        }
        public virtual void sayName()
        {

        }
    }
}
