using Oroox.SubSuppliers.Modules.User.Requests.Customer;
using Oroox.SubSuppliers.RequestHandlers;
using System;
using System.Linq;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customer.Requests.Processors
{
    public class AddCustomerRegistration : IPostRequestProcessor<CreateCustomer>
    {
        private const string AvailableCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private Random random = new Random();
        private string ActivationCode => new string
        (
                Enumerable
                    .Repeat(AvailableCharacters, 10)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray()
        );
        public void Process(CreateCustomer request, CancellationToken cancelationToken)
        {
            request.Customer.Registration = new Domain.Entities.Registration()
            {
                ActivationCode = ActivationCode,
            };
        }
    }
}
