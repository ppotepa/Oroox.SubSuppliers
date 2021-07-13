using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AssignJobToCustomer.Model
{
    public class AssignJobToCustomerModel
    {
        public CustomerDTO Customer { get; set; }
        public SharedJobDTO SharedJob { get; set; }
    }

    public class AssignJobToCustomerModelMappingProfile : Profile
    {
        public AssignJobToCustomerModelMappingProfile()
        {
            CreateMap<AssignJobToCustomerModel, AssignJobToCustomerRequest>().ReverseMap();
            CreateMap<CustomerDTO, Customer>().ReverseMap();
            CreateMap<SharedJobDTO, SharedJob>().ReverseMap();
        }
    }
}
