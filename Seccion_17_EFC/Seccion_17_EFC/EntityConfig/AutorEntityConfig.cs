using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seccion_17_EFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_17_EFC.EntityConfig
{
    public class AutorEntityConfig
    {
        public static void SetAutorEntityConfig(EntityTypeBuilder<Autor> entityBuilder)
        {
            entityBuilder.HasKey(x => x.AutorId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
        }
    }
}
