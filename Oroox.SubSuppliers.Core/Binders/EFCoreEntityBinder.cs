using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Extensions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Core.Binders
{
    public class EFCoreEntityBinder<TRequest> : IEntityBinder<TRequest> where TRequest : IBaseRequest
    {
        private readonly IApplicationContext context;

        public EFCoreEntityBinder(IApplicationContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Attach(TRequest request, CancellationToken cancelationToken)
        {
            Entity[] entities = request.GetType().GetProperties()
                                        .Where(property => property.PropertyType.BaseType == typeof(Entity))
                                        .Select(property => property.GetValue(request) as Entity)
                                        .ToArray();

            entities.ForEach(entity => this.context.AttachEntity(entity));
            return await Unit.Task;
        }
    }
}
