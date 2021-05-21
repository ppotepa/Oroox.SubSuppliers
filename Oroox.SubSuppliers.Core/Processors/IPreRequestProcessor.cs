using System.Threading;

namespace Oroox.SubSuppliers.RequestHandlers
{
    public interface IPreRequestProcessor<in TRequest>
    {
        void Process(TRequest request, CancellationToken cancelationToken);
    }
}
