using MediatR;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.DTO;
using Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.PostProcessors
{
    public class ProcessResponse : IRequestPostProcessor<AddSharedJobCommentRequest, AddSharedJobCommentResponse>
    {
        public Task Process(AddSharedJobCommentRequest request, AddSharedJobCommentResponse response, CancellationToken cancellationToken)
        {
            response.Result = new Model.AddSharedJobCommentResponseModel
            {
                Comment = new CommentResponseDTO
                {
                    Id = request.Comment.Id,
                    Attachment = new AttachmentResponseDTO
                    {
                        Id = request.Comment?.Attachment?.Id
                    }
                }
            };

            return Unit.Task;
        }
    }
}
