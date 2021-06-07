using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.AddTurningMachine.DTO;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMachineRequest.Model
{
    public class AddCustomerMachine
    {
        public AddCustomerMachineDTO Machine { get; set; }
    }

    public class AddTurningMachineRequestMappingProfile : Profile
    {
        public AddTurningMachineRequestMappingProfile()
        {
            CreateMap<AddCustomerMachineDTO, Machine>().ReverseMap();
            CreateMap<AddCustomerMachine, AddCustomerMachineRequest>().ReverseMap();           
        }
    }

}
