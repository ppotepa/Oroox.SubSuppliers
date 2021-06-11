using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Domain.Extensions
{
    public static partial class DbSetDomainExtensions
    {
        public static IQueryable<TEntity> GetById<TEntity>(this DbSet<TEntity> @this, Guid entityId, string include = "") where TEntity : Entity
            => @this.Where(x => x.Id == entityId).AsQueryable();

        public static IQueryable<TEntity> GetByIdAsync<TEntity>(this DbSet<TEntity> @this, Guid entityId, string include = "") where TEntity : Entity
            => @this.Where(x => x.Id == entityId).AsQueryable();
    }
}
