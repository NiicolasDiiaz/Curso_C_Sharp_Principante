using Seccion_17_EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.Services
{
    public interface IAlbumService
    {
        void AddAlbum(Album album);

        Album GetAlbum(int AlbumId);
        List<Album> GetAlbumes();

        void DeleteAlbum(Album album);
        void DeleteAlbum(int AlbumId);

        Album UpdateAlbum(Album album);
    }
}
