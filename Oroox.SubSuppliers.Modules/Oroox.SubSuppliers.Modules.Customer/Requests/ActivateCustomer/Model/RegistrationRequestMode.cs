using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer.DTO;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer.Model
{
    public class ActivateCustomerModel
    {
        public RegistrationDTO Registration { get; set; }
    }

    public class ActivateCustomerModelMappingProfile : Profile
    {
        public ActivateCustomerModelMappingProfile()
        {
            CreateMap<Registration, RegistrationDTO>().ReverseMap();
            CreateMap<ActivateCustomerModel, ActivateCustomerRequest>().ReverseMap();
        }
    }
}
