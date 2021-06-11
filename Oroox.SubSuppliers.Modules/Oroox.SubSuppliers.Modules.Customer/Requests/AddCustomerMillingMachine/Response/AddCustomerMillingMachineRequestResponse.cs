using Oroox.SubSuppliers.Response;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Response
{
    public class AddCustomerMillingMachineRequestResponse : BaseRespone
    {
        public Guid[] MachineIds { get; internal set; }
    }
}
