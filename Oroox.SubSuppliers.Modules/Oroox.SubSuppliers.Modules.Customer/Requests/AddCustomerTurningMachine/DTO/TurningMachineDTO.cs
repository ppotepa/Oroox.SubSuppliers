using System;

namespace Oroox.SubSuppliers.Modules.Customers.AddTurningMachine.DTO
{
    public class TurningMachineDTO
    {
        public string MachineNumber { get; set; }
        public double? XMin { get; set; }
        public double? XMax { get; set; }

        public double? YMin { get; set; }
        public double? YMax { get; set; }
        public string Name { get; set; }
        public Guid TurningMachineTypeId { get; set; }
        public Guid CNCMachineAxesTypeId { get; set; }
    }
}
