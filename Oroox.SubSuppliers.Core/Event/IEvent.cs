using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Event
{
    public interface IEvent<TRequest> where TRequest : IBaseRequest
    {
        Task<Unit> Handle(TRequest request, CancellationToken cancelationToken);
    }
}
