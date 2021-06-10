using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class MillingMachine : CNCMachine
    {
        public double ZMin { get; set; }
        public double ZMax { get; set; }
        public virtual CNCMachineAxesType CNCMachineAxesType { get; set; }
        public Guid CNCMachineAxesTypeId { get; set; }
    }
}