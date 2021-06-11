using Oroox.SubSuppliers.Response;
using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachine.Response
{
    public class AddCustomerTurningMachineRequestResponse : BaseRespone
    {
        public IEnumerable<Guid> MachineIds { get; set; }
    }
}