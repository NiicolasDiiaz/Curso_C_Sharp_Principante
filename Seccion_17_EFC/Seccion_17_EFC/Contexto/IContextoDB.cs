using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seccion_17_EFC.Models;

namespace Seccion_17_EFC.Contexto
{
    public interface IContextoDB
    {
        DbSet<Cancion> Canciones { get; set; }

       
        int SaveChanges();
       
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
