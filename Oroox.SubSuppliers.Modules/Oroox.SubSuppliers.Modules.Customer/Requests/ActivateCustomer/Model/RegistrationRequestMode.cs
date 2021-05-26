using AutoMapper;
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
            CreateMap<Domain.Entities.Registration, RegistrationDTO>().ReverseMap();
            CreateMap<ActivateCustomerModel, ActivateCustomerRequest>().ReverseMap();
        }
    }
}
