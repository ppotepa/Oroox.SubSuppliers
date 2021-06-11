using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.DTO;
using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Model
{
    public class AddCustomerMillingMachineModel
    {
        public MillingMachineDTO[] MillingMachines { get; set; }
        public Guid CustomerId { get; set; }

    }

    public class AddCustomerMillingMachineMappingProfile : Profile
    {
        public AddCustomerMillingMachineMappingProfile()
        {
            CreateMap<MillingMachineDTO, MillingMachine>().ReverseMap();
            CreateMap<AddCustomerMillingMachineModel, AddCustomerMillingMachineRequest>().ReverseMap();
        }
    }
}
