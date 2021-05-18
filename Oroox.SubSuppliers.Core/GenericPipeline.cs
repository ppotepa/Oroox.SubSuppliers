using MediatR;
using Oroox.SubSuppliers.Processors;
using Oroox.SubSuppliers.Utilities.Extensions;
using Oroox.SubSuppliers.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers
{
    public class GenericPipeline<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
    {
        private readonly IRequestHandler<TRequest, TResponse> inner;
        private readonly IEnumerable<IMessageValidator<TRequest>> validators;
        private readonly IEnumerable<IPreRequestProcessor<TRequest>> preProcessors;
        private readonly IEnumerable<IPostRequestProcessor<TRequest, TResponse>> postProcessors;
        private readonly IEnumerable<IResponseProcessor<TResponse>> responseProcessors;
        public GenericPipeline() { }
        public GenericPipeline
        (
            IRequestHandler<TRequest, TResponse> inner,
            IEnumerable<IMessageValidator<TRequest>> validators,
            IEnumerable<IPreRequestProcessor<TRequest>> preProcessors,
            IEnumerable<IPostRequestProcessor<TRequest, TResponse>> postProcessors,
            IEnumerable<IResponseProcessor<TResponse>> responseProcessors
        )
        {
            this.inner = inner;
            this.validators = validators;
            this.preProcessors = preProcessors;
            this.postProcessors = postProcessors;
            this.responseProcessors = responseProcessors;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            preProcessors.ForEach(preProcessor =>
            {
                preProcessor.Handle(request);
            });

            List<ValidationFailure> failures = this.validators.Select(validator => validator.Validate(request))
                .SelectMany(result => result)
                .Where(failure => failure != null)
                .ToList();

            if (failures.Any())
            {
                throw new ValidationException(null);
            }

            TResponse response = await inner.Handle(request, cancellationToken);
            postProcessors.ForEach(postProcessor => postProcessor.Handle(request, response));
            responseProcessors.ForEach(responseProcessor => responseProcessor.Handle(response));           

            return response;
        }
    }
}
