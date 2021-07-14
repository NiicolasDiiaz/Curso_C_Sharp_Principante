using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seccion_17_EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.EntityConfig
{
    public class CancionEntityConfig
    {
        public static void SetCancionEntityConfig(EntityTypeBuilder<Cancion> entityBuilder)
        {
            entityBuilder.HasKey(x => x.CancionId);
            entityBuilder.Property(x => x.Titulo).IsRequired();
            entityBuilder.Property(x => x.Descripcion).HasMaxLength(100);

        }
    }
}
