using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.CreateCustomer.DTO;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer;

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
            CreateMap<Customer, CreateCustomerDTO>().ReverseMap().ForMember(dto => dto.Machines, customer => customer.MapFrom(m => m.MillingMachines));
            CreateMap<Machine, CreateCustomerTurningMachineDTO>().ReverseMap();

            CreateMap<MillingMachine, MillingMachineDTO>();
            CreateMap<MillingMachineDTO, MillingMachine>();

            CreateMap<CreateCustomerModel, CreateCustomerRequest>();
            CreateMap<CreateCustomerRequest, CreateCustomerModel>();
        }
    }
}
