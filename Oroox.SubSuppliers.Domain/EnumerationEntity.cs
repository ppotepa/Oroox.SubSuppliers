using System;

namespace Oroox.SubSuppliers.Domain
{


    public class EnumerationEntity<TEnumType> : IEnumerationEntity where TEnumType : Enum
    {
        private string _value;
        public Type EnumType => typeof(TEnumType);

        public Guid Id { get; set; }

        public string Name
        {
            get => Value.ToString();
            set => _value = value;
        }

        public TEnumType Value { get; set; }
    }
}
