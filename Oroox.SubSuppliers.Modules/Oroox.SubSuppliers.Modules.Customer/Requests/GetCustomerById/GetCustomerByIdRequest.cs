using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.GetCustomerById.Response;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.GetCustomerById
{
    public class GetCustomerByIdRequest : IRequest<GetCustomerByIdResponse>
    {
        public Customer Customer { get; set; }
    }
}
