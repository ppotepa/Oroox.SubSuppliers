using AutoMapper;
using Oroox.SubSuppliers.Modules.Jobs.Requests.CreateNewJob;

namespace Oroox.SubSuppliers.Modules.Jobs.RequestsCreateNewJob.Model
{
    public class CreateNewJobModel
    {

    }

    public class CreateNewJobModelProfile : Profile 
    {
        public CreateNewJobModelProfile()
        {
            CreateMap<CreateNewJobModel, CreateNewJobRequest>().ReverseMap(); 
        }
    }
}