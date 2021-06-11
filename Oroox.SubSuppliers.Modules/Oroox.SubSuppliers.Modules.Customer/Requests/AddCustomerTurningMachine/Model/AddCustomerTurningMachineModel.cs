using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.AddTurningMachine.DTO;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachine.Model
{
    public class AddCustomerTurningMachineModel
    {
        public TurningMachineDTO[] TurningMachines { get; set; }
        public Guid CustomerId { get; set; }
    }

    public class AddTurningMachineRequestMappingProfile : Profile
    {
        public AddTurningMachineRequestMappingProfile()
        {
            CreateMap<TurningMachineDTO, TurningMachine>().ReverseMap();            
            CreateMap<AddCustomerTurningMachineModel, AddCustomerMillingMachineRequest>().ReverseMap();           
        }
    }

}
