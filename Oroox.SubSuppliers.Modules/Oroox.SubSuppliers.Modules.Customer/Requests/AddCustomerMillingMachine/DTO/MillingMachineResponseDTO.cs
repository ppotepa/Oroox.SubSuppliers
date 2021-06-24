using Oroox.SubSuppliers.Domain.Entities;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.DTO
{
    public class MillingMachineResponseDTO
    {
        public string MachineNumber { get; set; }
        public Guid Id { get; set; }
        public static MillingMachineResponseDTO FromMachine(Machine machine) => new MillingMachineResponseDTO
        {
            Id = machine.Id,
            MachineNumber = machine.MachineNumber
        };
    }
}
