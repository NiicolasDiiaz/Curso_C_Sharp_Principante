using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_11_Conceptos_Avanzados
{
    class ListaTotal<T>
    {
        List<T> lista = new List<T>();
         
        public void Anadir(T entrada)
        {
            lista.Add(entrada);
        }

        public List<T> ObtenerLista()
        {
            return lista;
        }
    }
}
