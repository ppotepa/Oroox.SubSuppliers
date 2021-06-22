using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Attachment : Entity
    {
        public virtual RegardingObject RegardingObject { get; set; }
        public byte[] Content { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
    }

    public class RegardingObject : Entity
    {
        public string EntityName { get; set; }
        public Guid RegardingObjectId { get; set; }

        [NotMapped]
        public Type EntityType
            => Type.GetType($"{EntitiesAssemblyNamespace}.{this.EntityName}", true);

        
        public static RegardingObject<TEntity> Obtain<TEntity>(DbContext context, Guid Id) where TEntity : Entity
        {
            TEntity @object = context.Find(typeof(TEntity), Id) as TEntity;
            RegardingObject<TEntity> result = new RegardingObject<TEntity>(@object);
            return result;
        }
    }

    [NotMapped]
    public class RegardingObject<TEntity> : Entity where TEntity : Entity
    {
        public readonly TEntity Entity;

        public RegardingObject(TEntity Entity)
        {
            this.Entity = Entity;
        }
    }
}
