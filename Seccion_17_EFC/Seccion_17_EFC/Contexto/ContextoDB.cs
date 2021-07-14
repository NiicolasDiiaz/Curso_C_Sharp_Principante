using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seccion_17_EFC.Models;

namespace Seccion_17_EFC.Contexto
{
    public class ContextoDB : DbContext, IContextoDB
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {

        }

        //Nombre de tabla: "Canciones"
        public DbSet<Cancion> Canciones {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
