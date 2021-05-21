using MediatR;
using System.Threading;

namespace Oroox.SubSuppliers.Event
{
    public interface IEvent<TRequest> where TRequest : IBaseRequest
    {
        void Handle(TRequest request, CancellationToken cancelationToken);
    }
}
