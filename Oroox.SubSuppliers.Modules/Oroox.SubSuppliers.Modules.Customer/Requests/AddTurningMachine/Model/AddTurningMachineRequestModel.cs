using AutoMapper;
using Oroox.SubSuppliers.Modules.Customers.AddTurningMachine.DTO;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddTurningMachine.Model
{
    public class AddTurningMachineRequestModel
    {
        public TurningMachineDTO TurningMachine { get; set; }
    }

    public class AddTurningMachineRequestMappingProfile : Profile
    {
        public AddTurningMachineRequestMappingProfile()
        {
            CreateMap<AddTurningMachineRequestModel, AddTurningMachineRequest>();
            CreateMap<AddTurningMachineRequest, AddTurningMachineRequestModel>();
        }
    }

}
