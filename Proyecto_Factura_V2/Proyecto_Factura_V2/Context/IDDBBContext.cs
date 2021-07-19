using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Context
{
    public interface IDDBBContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Branch> Branches { get; set; }

        int SaveChanges();

    }
}
