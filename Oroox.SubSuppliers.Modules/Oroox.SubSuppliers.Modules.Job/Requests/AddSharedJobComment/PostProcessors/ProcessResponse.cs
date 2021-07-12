using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.DTO;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Response;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.PostProcessors
{
    public class ProcessResponse : IRequestPostProcessor<AddSharedJobCommentRequest, AddSharedJobCommentResponse>
    {
        private readonly IApplicationContext context;
        public ProcessResponse(IApplicationContext context)
        {
            this.context = context;
        }


        public Task Process(AddSharedJobCommentRequest request, AddSharedJobCommentResponse response, CancellationToken cancellationToken)
        {
            Comment entry = this.context.NewEntries()
                                        .Select(entry => entry.Entity as Comment)
                                        .FirstOrDefault();

            if (entry != null)
            {
                response.Result = new Model.AddSharedJobCommentResponseModel
                {
                    Comment = new CommentResponseDTO
                    {
                        Id = entry.Id,
                        Attachment = entry.Attachment is null ? null : new AttachmentResponseDTO
                        {
                            Id = entry.Attachment?.Id
                        }
                    }
                };
            }

            return Unit.Task;
        }
    }
}
