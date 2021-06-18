using AutoMapper;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.RequestsCreateNewJob.Model
{
    public class CreateNewJobModel
    {
        public Guid QuoteId { get; set; }
    }

    public class CreateNewJobModelProfile : Profile 
    {
        public CreateNewJobModelProfile()
        {
            CreateMap<CreateNewJobModel, CreateNewJobRequest>().ReverseMap(); 
        }
    }
}