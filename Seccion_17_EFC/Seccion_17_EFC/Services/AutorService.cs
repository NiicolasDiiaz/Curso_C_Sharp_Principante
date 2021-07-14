using Seccion_17_EFC.Contexto;
using Seccion_17_EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.Services
{
    public class AutorService : IAutorService
    {
        private readonly IContextoDB _contextoDB;

        public AutorService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddAutor(Autor autor)
        {
            _contextoDB.Autores.Add(autor);
            _contextoDB.SaveChanges();
        }

        public Autor GetAutor(int AutorId)
        {
            return _contextoDB.Autores.Where(x => x.AutorId == AutorId).FirstOrDefault();
        }
        public List<Autor> GetAutores()
        {
            return _contextoDB.Autores.Select(x => x).ToList();
        }

        public void DeleteAutor(Autor autor)
        {
            _contextoDB.Autores.Remove(autor);
            _contextoDB.SaveChanges();
        }
        public void DeleteAutor(int AutorId)
        {
            var autor = GetAutor(AutorId);
            DeleteAutor(autor);
        }

        public Autor UpdateAutor(Autor autor)
        {
            var autorUpdated = _contextoDB.Autores.Update(autor).Entity;
            _contextoDB.SaveChanges();
            return autorUpdated;
        }
    }
}
