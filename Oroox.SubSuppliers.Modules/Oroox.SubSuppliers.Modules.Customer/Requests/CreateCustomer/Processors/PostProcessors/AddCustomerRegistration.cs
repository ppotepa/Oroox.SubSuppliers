using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer.Responses;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer.PostProcessors
{
    public class AddCustomerRegistration : IRequestPostProcessor<CreateCustomerRequest, CreateCustomerRequestResponse>
    {
        private const string AvailableCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private Random Random => new Random();
        private string ActivationCode => GetActivationCode();
        public Task Process(CreateCustomerRequest request, CreateCustomerRequestResponse response, CancellationToken cancellationToken)
        {
            request.Customer.Registration = new Domain.Entities.Registration()
            {
                ActivationCode = ActivationCode,
            };

            return Unit.Task;
        }

        private string GetActivationCode() => new string
        (
            Enumerable.Repeat(AvailableCharacters, 10)
                .Select(@string => @string[Random.Next(@string.Length)])
                .ToArray()
        );
    }
}
