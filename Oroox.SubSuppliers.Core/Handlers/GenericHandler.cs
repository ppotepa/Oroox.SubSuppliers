using FluentValidation.Results;
using MediatR;
using Oroox.SubSuppliers.Processors;
using Oroox.SubSuppliers.Response;
using Oroox.SubSuppliers.Validation;
using System.Collections.Generic;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Handlers
{
    public class GenericHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
        where TResponse : ResponseBase, new()
    {
        private readonly IEnumerable<IRequestValidator<TRequest>> validators;
        private readonly IEnumerable<IPreRequestProcessor<TRequest>> preProcessors;
        private readonly IEnumerable<IPostRequestProcessor<TRequest, TResponse>> postProcessors;
        private readonly IEnumerable<IResponseProcessor<TResponse>> responseProcessors;

        public GenericHandler
        (
            IEnumerable<IRequestValidator<TRequest>> validators
            //IEnumerable<IPreRequestProcessor<TRequest>> preProcessors,
            //IEnumerable<IPostRequestProcessor<TRequest, TResponse>> postProcessors
        )
        {
            this.validators = validators;
            //this.preProcessors = preProcessors;
            //this.postProcessors = postProcessors;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            //preProcessors.ToList().ForEach(preProcessor =>
            //{
            //    preProcessor.Handle(request);
            //});

            List<ValidationResult> failures = this.validators.Select(validator => validator.Process(request)).Where(failure => failure != null).ToList();

            //if (failures.Any())
            //{
            //    throw new ValidationException(null);
            //}

            //postProcessors.ToList().ForEach(postProcessor => postProcessor.Handle(request, response));
            //responseProcessors.ToList().ForEach(responseProcessor => responseProcessor.Handle(response));

                return new TResponse()
                {
                    Response = "Test",
                    ValidationMessage = "Test",
                    Result = new object[] { "Test", 123, new Dictionary<string, object>() { ["Test"] = new {a = "Test", b = "Test2"} }
                }
            };
        }
    }
}
