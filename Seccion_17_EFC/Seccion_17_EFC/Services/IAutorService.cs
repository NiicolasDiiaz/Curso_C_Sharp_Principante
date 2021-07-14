using Seccion_17_EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.Services
{
    public interface IAutorService
    {
        void AddAutor(Autor autor);

        Autor GetAutor(int AutorId);
        List<Autor> GetAutores();

        void DeleteAutor(Autor autor);
        void DeleteAutor(int AutorId);

        Autor UpdateAutor(Autor autor);
    }
}
