using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Oroox.SubSuppliers.Modules.Customers.DTO;
using Oroox.SubSuppliers.Modules.Customers.Requests;

namespace Oroox.SubSuppliers.Modules.Customers.Model
{
    [AutoMap(typeof(CreateCustomerRequest))]
    public class CreateCustomerModel
    {
        [SourceMember(nameof(CreateCustomerRequest.Customer))]
        public CreateCustomerDTO Customer { get; set; }
    }
}
