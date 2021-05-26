﻿using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Processors;
using System.Linq;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.PreProcessors
{
    public class BindWithCustomer : IPreRequestProcessor<UpdateCustomerAdditionalInfoRequest>
    {
        private readonly IApplicationContext context;
        public BindWithCustomer(IApplicationContext context)
        {
            this.context = context;
        }

        public void Process(UpdateCustomerAdditionalInfoRequest request, CancellationToken cancelationToken)
        {
            Customer targetCustomer = this.context.Customers.FirstOrDefault(x => x.Id == request.CustomerAdditionalInfo.CustomerId);
            request.CustomerAdditionalInfo.Customer = targetCustomer;
        }
    }
}
