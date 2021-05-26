using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.DTO;
using Oroox.SubSuppliers.Modules.Customers.Requests;

namespace Oroox.SubSuppliers.Modules.Customers.Model
{
    [AutoMap(typeof(CreateCustomerRequest))]
    public class CreateCustomerModel
    {
        public CreateCustomerDTO Customer { get; set; }
    }
    
    public class CreateCustomerMappingProfile : Profile
    {
        public CreateCustomerMappingProfile()
        {
            CreateMap<Customer, CreateCustomerDTO>().ReverseMap().ForMember(dto => dto.MillingMachines, customer => customer.MapFrom(m => m.MillingMachines));
            CreateMap<TurningMachine, TurningMachineDTO>().ReverseMap();

            CreateMap<MillingMachine, MillingMachineDTO>();
            CreateMap<MillingMachineDTO, MillingMachine>();

            CreateMap<CreateCustomerModel, CreateCustomerRequest>();
            CreateMap<CreateCustomerRequest, CreateCustomerModel>();
        }
    }
}
