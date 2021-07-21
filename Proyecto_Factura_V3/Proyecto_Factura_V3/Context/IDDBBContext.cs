using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Context
{
    public interface IDDBBContext
    {

        //Añado DbSet para cada clase. Una tabla por clase. Nombre en plural:
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Branch> Branches { get; set; }

        //Metodo de DbContext para materializar los cambios:
        int SaveChanges();
    }
}
