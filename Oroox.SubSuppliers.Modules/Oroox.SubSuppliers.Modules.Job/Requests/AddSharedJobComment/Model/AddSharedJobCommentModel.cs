using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.DTO;
using System;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Model
{
    public class AddSharedJobCommentModel
    {        
        public Guid SharedJobId { get; set; }
        public CommentDTO Comment { get; set; }
    }

    public class AddSharedJobCommentMappingProfile : Profile
    {
        public AddSharedJobCommentMappingProfile()
        {
            CreateMap<AttachmentDTO, Attachment>().ReverseMap();
            CreateMap<CommentDTO, Comment>().ReverseMap();
            CreateMap<AddSharedJobCommentModel, AddSharedJobCommentRequest>().ReverseMap();
        }
    }
}