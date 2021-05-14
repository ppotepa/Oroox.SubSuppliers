using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class TurningMachine : Entity
    {
        public virtual Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
        public TurningMachineType TurningMachineType { get; set; }
        public string MachineNumber { get; set; }
        public int MinimalMachiningDimensions { get; set; }
        public int MaximalMachiningDimensions { get; set; }
    }
}