using System.Threading;

namespace Oroox.SubSuppliers.Processors
{
    public interface IPreRequestProcessor<in TRequest>
    {
        void Process(TRequest request, CancellationToken cancelationToken);
    }
}
