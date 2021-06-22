using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain.Extensions
{
    public static partial class DbContextExtensions
    {
        //public async static Task<TEntity> FindRegardingObject<TEntity>(this DbContext @this, Guid id) where TEntity : Entity
        //{
        //    RegardingObject regardingObject = await @this.Set<RegardingObject>()
        //                        .FirstAsync(obj => obj.EntityName == typeof(TEntity).Name && obj.RegardingObjectId == id);
        //}
    }
}
