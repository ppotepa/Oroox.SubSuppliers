using MediatR;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Response;
using Oroox.SubSuppliers.Utilities.Extensions;
using Oroox.SubSuppliers.Validation;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Handlers
{
    public sealed class GenericPipeline<TRequest, TResponse> :  IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : ResponseBase, new()
    {
        private readonly IEnumerable<IRequestValidator<TRequest>> validators;
        private readonly ILogger logger;
        private readonly IMediator mediator;
        private readonly IEnumerable<IRequestValidator<TRequest>> postProcessors;
      

        public GenericPipeline
        (
            IEnumerable<IRequestValidator<TRequest>> validators, 
            IEnumerable<IRequestValidator<TRequest>> postProcessors, 
            ILogger logger, 
            IMediator mediator
        )
        {
            this.validators = validators;
            this.logger = logger;
            this.mediator = mediator;
            this.postProcessors = postProcessors;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            this.logger.Information($"Processing a request {typeof(TRequest).Name}.");
            this.logger.Information($"Request payload {request.ToJsonString(true)}.");

            string[] validationMessages = this.validators.Select(validator => validator.Process(request)).GetValidationMessages().ToArray();

            if (validationMessages.Any())
            {
                return new TResponse
                {
                    Response = "There were some validation errors.",
                    ValidationMessages = validationMessages
                };
            }

            return await Task.FromResult<TResponse>(default);
        }
    }
}
