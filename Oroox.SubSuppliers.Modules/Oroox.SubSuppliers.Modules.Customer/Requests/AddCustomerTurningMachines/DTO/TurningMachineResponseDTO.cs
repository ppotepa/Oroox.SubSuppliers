using Oroox.SubSuppliers.Domain.Entities;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.AddTurningMachine.DTO
{
    public class TurningMachineResponseDTO
    {
        public Guid Id { get; set; }
        public string MachineNumber { get; set; }
        public static TurningMachineResponseDTO FromMachine(Machine machine) => new TurningMachineResponseDTO
        {
            Id = machine.Id,
            MachineNumber = machine.MachineNumber
        };
    }
}
