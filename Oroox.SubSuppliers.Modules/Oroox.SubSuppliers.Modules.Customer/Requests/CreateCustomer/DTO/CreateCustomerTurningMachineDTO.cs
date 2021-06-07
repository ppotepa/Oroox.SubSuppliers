using System;

namespace Oroox.SubSuppliers.Modules.Customers.CreateCustomer.DTO
{
    public class CreateCustomerTurningMachineDTO
    {
        public string MachineNumber { get; set; }
        public int MinimalMachiningDimensions { get; set; }
        public int MaximalMachiningDimensions { get; set; }
        public Guid TurningMachineTypeId { get; set; }
    }
}
