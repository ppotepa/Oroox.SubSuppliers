using Oroox.SubSuppliers.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace Oroox.SubSuppliers.Domain
{
    public class Entity 
    {
        public object this[string propertyName] => _properties[propertyName];
        public bool HasRootEntity => this.GetType().BaseType != null && this.GetType().BaseType != typeof(object);
        private void UpdateProperty(string propertyName, object @value)
        {
            this.Properties[propertyName].SetMethod.Invoke(this, new object[] { @value });
        }

        private Dictionary<string, PropertyInfo> _properties = default;

        [NotMapped]
        public Dictionary<string, PropertyInfo> Properties
        {
            get
            {
                if (_properties is null)
                {
                    this._properties = this.GetType()
                                                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                                    .Where(prop => prop.CanWrite && prop.Name != "Properties")
                                                    .ToDictionary(x => x.Name, x => x);

                }
                return _properties;
            }

            set => this._properties = value;
        }

        public Entity() { }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public Guid Id { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual void Update(Entity entity)
            => entity.Properties
                .Where(kvp => kvp.Value.GetValue(entity) != null && !ShadowProperties.Contains(kvp.Value.Name))
                .ForEach(x => this.UpdateProperty(x.Key, x.Value.GetValue(entity)));

        private static readonly string[] ShadowProperties = typeof(Entity).GetProperties().Select(p => p.Name).ToArray();

        public void MarkAsDeleted() => this.Deleted = true;
    }

    public class EnumerationEntity<TEnumType> : IEnumerationEntity where TEnumType : Enum
    {
        private string _value;
        public TEnumType Value { get; set; }
        public string Name { get => Value.ToString(); set => _value = value; }
        public Guid Id { get; set; }
        
    }

    public interface IEnumerationEntity 
    {
        Guid Id { get; set; }
    }
}
