using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class MillingMachine : Entity
    {
        public virtual Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
        public string MachineNumber { get; set; }
        public MillingMachineType MachineType { get; set; }
        public MillingMachineDimensionsType MillingMachineDimensionsType { get; set; }
        public string Name { get; set; }
        public int MinimalMachiningDimensions { get; set; }
        public int MaximalMachiningDimensions { get; set; }
    }
}