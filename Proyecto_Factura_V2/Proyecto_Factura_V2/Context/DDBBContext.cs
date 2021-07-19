using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V2.Models;
using Proyecto_Factura_V2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Factura_V2.EntityConfig;

namespace Proyecto_Factura_V2.Context
{
    public class DDBBContext : DbContext, IDDBBContext
    {
        public DDBBContext(DbContextOptions<DDBBContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            //Si se quiere asignar nombre especifico a las tablas, distinto al de la variable DbSet:
            //modelBuilder.Entity<Product>().ToTable("Products")

            //Asignar configuraciones entidad principal y otras entidades:
            //ProductEntityConfig.SetProductEntityConfig(modelBuilder.Entity<Product>());
        }
    }
}
