using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.DTO;
using Oroox.SubSuppliers.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Response
{
    public class AddCustomerMillingMachineRequestResponse : BaseRespone
    {
        public NewMillingMachineResponseDTO[] MachineIds { get; internal set; }
    }
}
