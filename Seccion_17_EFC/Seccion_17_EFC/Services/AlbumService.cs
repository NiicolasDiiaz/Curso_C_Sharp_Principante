using Seccion_17_EFC.Contexto;
using Seccion_17_EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IContextoDB _contextoDB;

        public AlbumService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddAlbum(Album album)
        {
            _contextoDB.Albumes.Add(album);
            _contextoDB.SaveChanges();
        }

        public Album GetAlbum(int AlbumId)
        {
            return _contextoDB.Albumes.Where(x => x.AlbumId == AlbumId).FirstOrDefault();
        }
        public List<Album> GetAlbumes()
        {
            return _contextoDB.Albumes.Select(x => x).ToList();
        }

        public void DeleteAlbum(Album album)
        {
            _contextoDB.Albumes.Remove(album);
            _contextoDB.SaveChanges();
        }
        public void DeleteAlbum(int AlbumId)
        {
            var album = GetAlbum(AlbumId);
            DeleteAlbum(album);
        }

        public Album UpdateAlbum(Album album)
        {
            var albumUpdated = _contextoDB.Albumes.Update(album).Entity;
            _contextoDB.SaveChanges();
            return albumUpdated;
        }
    }
}
