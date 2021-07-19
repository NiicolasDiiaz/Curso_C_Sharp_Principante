using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Seccion_22_API.Models;

namespace Seccion_22_API.DataAccess
{
    public class BBDDContext : DbContext, IBBDDContext
    {
        public BBDDContext(DbContextOptions<BBDDContext> options) : base(options)
        {

        }
        public DbSet<ItemModel> ModelItem{ get; set; }
    }
}
