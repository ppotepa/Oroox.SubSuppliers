using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment.DTO;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment
{
    public class UpdateSharedJobCommentModel 
    {
        public CommentDTO Comment { get; set; }
        public NewCommentDTO NewComment { get; set; }
    }

    public class UpdateSharedJobMappingProfile : Profile
    {
        public UpdateSharedJobMappingProfile()
        {
            CreateMap<UpdateSharedJobCommentRequest, UpdateSharedJobCommentModel>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
            CreateMap<Comment, NewCommentDTO>().ReverseMap();
        }
    }
}
