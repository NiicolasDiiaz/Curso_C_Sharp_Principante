using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seccion_17_EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.EntityConfig
{
    public class AlbumEntityConfig
    {
        public static void SetAlbumEntityConfig(EntityTypeBuilder<Album> entityBuilder)
        {
            entityBuilder.HasKey(x => x.AlbumId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
        }
    }
}
