using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.DTO
{
    public class MillingMachineDTO
    {
        public string MachineNumber { get; set; }
        public double? XMin { get; set; }
        public double? XMax { get; set; }

        public double? YMin { get; set; }
        public double? YMax { get; set; }

        public double? ZMin { get; set; }
        public double? ZMax { get; set; }

        public string Name { get; set; }        
        public Guid CNCMachineAxesTypeId { get; set; }
    }
}
