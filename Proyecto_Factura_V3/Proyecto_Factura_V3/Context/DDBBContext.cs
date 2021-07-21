using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Context
{
    //Hereda de DbContext y de su interfaz definida
    public class DDBBContext: DbContext, IDDBBContext
    {
        public DDBBContext(DbContextOptions<DDBBContext> options) : base(options)
        {

        }

        //Añado DbSet para cada clase. Una tabla por clase. Nombre en plural:
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Branch> Branches { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Si se quiere asignar nombre especifico a las tablas, distinto al de la variable DbSet:
            //modelBuilder.Entity<Product>().ToTable("Products")

            //Asignar configuraciones entidad principal y otras entidades desde EntityConfig:
            //ProductEntityConfig.SetProductEntityConfig(modelBuilder.Entity<Product>());
        }
    }
}
