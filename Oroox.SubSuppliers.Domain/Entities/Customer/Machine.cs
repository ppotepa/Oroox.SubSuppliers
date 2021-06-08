using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public enum CNCMachineTypeEnum { MILLING, TURNING }
    public abstract class Machine : Entity
    {
        public virtual Customer Customer { get; set; }
        public string MachineNumber { get; set; }
        public string Name { get; set; }
        public Guid CustomerId { get; set; }
    }
   
    public abstract class CNCMachine : Machine
    {
        public double? XMin { get; set; }
        public double? XMax { get; set; }

        public double? YMin { get; set; }
        public double? YMax { get; set; }

        public CNCMachineTypeEnum Type
            => this.GetType() == typeof(MillingMachine) ? CNCMachineTypeEnum.MILLING : CNCMachineTypeEnum.TURNING;
    };
}