using System;

namespace Oroox.SubSuppliers.Domain
{
    public class Entity
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public Guid Id { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
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
