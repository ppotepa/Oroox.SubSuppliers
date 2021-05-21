using System.Threading;

namespace Oroox.SubSuppliers.RequestHandlers
{
    public interface IPostRequestProcessor<in TRequest>
    {
        void Process(TRequest request, CancellationToken cancelationToken);
    }
}
