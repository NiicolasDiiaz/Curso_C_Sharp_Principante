using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Context
{
    public class DDBBContext : DbContext
    {
        public DDBBContext(DbContextOptions<DDBBContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {

        }
    }
}
