using System;

namespace Oroox.SubSuppliers.Domain
{
    public class EnumerationEntity<TEnumType> : IEnumerationEntity where TEnumType : Enum
    {
        private string _value;
        public TEnumType Value { get; set; }
        public string Name { get => Value.ToString(); set => _value = value; }
        public Guid Id { get; set; }


        public override int GetHashCode() => HashCode.Combine(this.Value);

        public static bool operator ==(EnumerationEntity<TEnumType> a, TEnumType b)
        {
            return Convert.ChangeType(a.Value, typeof(int)).Equals(Convert.ChangeType(b, typeof(int)));
        }

        public static bool operator !=(EnumerationEntity<TEnumType> a, TEnumType b)
            => !Convert.ChangeType(a.Value, typeof(int)).Equals(Convert.ChangeType(b, typeof(int)));
        
    }
}
