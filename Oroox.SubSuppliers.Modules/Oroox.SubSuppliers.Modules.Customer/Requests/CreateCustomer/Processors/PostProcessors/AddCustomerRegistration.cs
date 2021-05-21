using Oroox.SubSuppliers.Processors;
using System;
using System.Linq;
using System.Threading;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.Processors
{
    public class AddCustomerRegistration : IPostRequestProcessor<CreateCustomerRequest>
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
        public void Process(CreateCustomerRequest request, CancellationToken cancelationToken)
        {
            request.Customer.Registration = new Domain.Entities.Registration()
            {
                ActivationCode = ActivationCode,
            };
        }
    }
}
