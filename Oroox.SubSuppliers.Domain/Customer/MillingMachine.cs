using Oroox.SubSuppliers.Core.Abstractions;
using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class MachineDimensions : Entity
    {
       public MachineDimensionsType MachineDimensionsType { get; set; }
    }

    public class MillingMachine : Entity
    {
        public MachineType MachineType { get; set; }    
        public string Name { get; set; }
        public int MachineNumber { get; set; }
        public MachineDimensions MachineDimensions {get;set;}
        public virtual Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}