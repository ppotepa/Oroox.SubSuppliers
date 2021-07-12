using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.UpdateSharedJobComment.DTO;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.DeleteSharedJobComment
{
    public class DeleteSharedJobCommentModel
    {
        public Guid CommentId { get; set; }
        public Guid SharedJobId { get; set; }
    }

    public class DeleteSharedJobCommentMappingProfile : Profile
    {
        public DeleteSharedJobCommentMappingProfile()
        {
            CreateMap<DeleteSharedJobCommentModel, DeleteSharedJobCommentRequest>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();            
        }
    }
}
