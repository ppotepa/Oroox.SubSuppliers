using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.AddTurningMachine.DTO;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.Model
{
    public class AddCustomerTurningMachinesModel
    {
        public TurningMachineDTO[] TurningMachines { get; set; }
        public Guid CustomerId { get; set; }
    }

    public class AddCustomerTurningMachinesMappingProfile : Profile
    {
        public AddCustomerTurningMachinesMappingProfile()
        {
            CreateMap<TurningMachineDTO, TurningMachine>().ReverseMap();
            CreateMap<AddCustomerTurningMachinesModel, AddCustomerTurningMachinesRequest>().ReverseMap();
        }
    }
}
