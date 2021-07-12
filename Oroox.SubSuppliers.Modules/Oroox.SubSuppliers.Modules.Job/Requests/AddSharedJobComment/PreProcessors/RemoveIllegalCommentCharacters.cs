using MediatR;
using MediatR.Pipeline;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Jobs.Requests.AddSharedJobComment.PreProcessors
{
    public class RemoveIllegalCommentCharacters : IRequestPreProcessor<AddSharedJobCommentRequest>
    {
        public async Task Process(AddSharedJobCommentRequest request, CancellationToken cancellationToken)
        {
            if (request.Comment != null && !string.IsNullOrEmpty(request.Comment.Text))
            {
                request.Comment.Text = 
                    string.Join(string.Empty, request.Comment.Text.Split(Path.GetInvalidFileNameChars()));
            }

            await Unit.Task;
        }
    }
}
