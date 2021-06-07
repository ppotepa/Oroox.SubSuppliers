using System;

namespace Oroox.SubSuppliers.Modules.Customers.CreateCustomer.DTO
{
    public class MillingMachineDTO
    {
        public string Name { get; set; }
        public int MinimalMachiningDimensions { get; set; }
        public int MaximalMachiningDimensions { get; set; }
        public Guid MillingMachineTypeId { get; set; }
        public Guid MillingMachineDimensionsTypeId { get; set; }
    }
}
