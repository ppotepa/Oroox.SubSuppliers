using MediatR;
using MediatR.Pipeline;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.PreProcessors
{
    public class RemoveIllegalFilenameCharacters : IRequestPreProcessor<AddSharedJobCommentRequest>
    {
        public async Task Process(AddSharedJobCommentRequest request, CancellationToken cancellationToken)
        {
            if (request.Comment.Attachment != null && request.Comment.Attachment.FileName != null)
            {
                request.Comment.Attachment.FileName = 
                    string.Join(string.Empty, request.Comment.Attachment.FileName.Split(Path.GetInvalidFileNameChars()));
            }

            await Unit.Task;
        }
    }
}
