using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_Factura_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.EntityConfig
{
    public class BranchEntityConfig
    {
        public static void SetBranchEntityConfig(EntityTypeBuilder<Branch> entityBuilder)
        {
            entityBuilder.HasKey(x => x.BranchId);
            //entityBuilder.Property(x => x.Name).IsRequired();
        }
    }
}
