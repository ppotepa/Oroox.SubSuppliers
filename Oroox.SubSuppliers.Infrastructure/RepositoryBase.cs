using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain;
using Oroox.SubSuppliers.Domain.Context;
using System;

namespace Oroox.SubSuppliers.Infrastructure
{
    public class RepositoryBase<TEntityType> : DbSet<TEntityType> 
        where TEntityType : Entity
    {
        private readonly SubSuppliersContext context;
        public RepositoryBase(SubSuppliersContext context)
        {
            this.context = context;
        }

        public Guid Insert(TEntityType entity) 
            => this.context.Add(entity).Entity.Id;
    }
}
