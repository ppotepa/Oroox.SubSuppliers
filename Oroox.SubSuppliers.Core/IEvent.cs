using MediatR;
using System.Threading;

namespace Oroox.SubSuppliers
{
    public interface IEvent<TRequest> where TRequest : IBaseRequest
    {
        public void Handle(TRequest request, CancellationToken cancelationToken);
    };
}