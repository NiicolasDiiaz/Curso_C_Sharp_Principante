using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Seccion_17_EFC.Contexto
{
    public class ContextoDB:DbContext
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
