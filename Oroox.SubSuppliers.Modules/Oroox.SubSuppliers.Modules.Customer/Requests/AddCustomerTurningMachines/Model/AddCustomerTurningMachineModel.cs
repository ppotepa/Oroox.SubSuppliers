using Oroox.SubSuppliers.Modules.Customers.AddTurningMachine.DTO;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.Model
{
    public class AddCustomerTurningMachineModel
    {
        public TurningMachineDTO[] TurningMachines { get; set; }
        public Guid CustomerId { get; set; }
    }
}
