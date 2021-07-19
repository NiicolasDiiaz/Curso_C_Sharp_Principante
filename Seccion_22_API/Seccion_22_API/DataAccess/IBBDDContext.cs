using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Seccion_22_API.Models;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Seccion_22_API.DataAccess
{
    public interface IBBDDContext
    {
        DbSet<ItemModel> ModelItem{ get; set; }

        DbSet<TEntity> Set<TEntity>([NotNullAttribute] string name) where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();

        void RemoveRange([NotNullAttribute] IEnumerable<object> entities);
        EntityEntry Update([NotNullAttribute] object entity);
    }
}
