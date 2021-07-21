using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.EntityConfig
{
    public class ProductEntityConfig
    {
        public static void SetProductEntityConfig(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductId);
            //entityBuilder.Property(x => x.Name).IsRequired();
        }
    }
}
