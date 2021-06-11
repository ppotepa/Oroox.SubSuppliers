using Oroox.SubSuppliers.Domain.Entities;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.DTO
{
    public class NewMillingMachineResponseDTO
    {
        public string MachineNumber { get; set; }
        public Guid Id { get; set; }
        public static NewMillingMachineResponseDTO FromMachine(Machine machine) =>
            new NewMillingMachineResponseDTO { Id = machine.Id, MachineNumber = machine.MachineNumber };

    }
}
