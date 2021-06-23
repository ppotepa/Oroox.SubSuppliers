using AutoMapper;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewSharedJob.Model
{
    public class CreateNewSharedJobModel
    {
        public Guid JobId { get; set; }
        public Guid CustomerId { get; set; }
    }

    public class CreateNewSharedJobMappingProfile : Profile
    {
        public CreateNewSharedJobMappingProfile()
        {
            CreateMap<CreateNewSharedJobModel, CreateNewSharedJobRequest>().ReverseMap();
        }
    }
}
