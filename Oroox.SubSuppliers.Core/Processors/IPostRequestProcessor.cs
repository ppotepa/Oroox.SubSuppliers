using System.Threading;

namespace Oroox.SubSuppliers.Processors
{
    public interface IPostRequestProcessor<in TRequest>
    {
        void Process(TRequest request, CancellationToken cancelationToken);
    }
}
