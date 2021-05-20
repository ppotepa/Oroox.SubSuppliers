using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Http;
using Oroox.SubSuppliers.Response;
using Oroox.SubSuppliers.Utilities.Extensions;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Handlers
{
    public sealed class GenericPipeline<TRequest, TResponse> :  IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : ResponseBase, new()
    {
        private readonly IEnumerable<AbstractValidator<TRequest>> validators;
        private readonly ILogger logger;
        private readonly IMediator mediator;
        private readonly IHttpContextAccessor context;
        private readonly string traceId;
        private readonly IRequestHandler<TRequest, TResponse> innerRequest;

        public GenericPipeline
        (
            IEnumerable<AbstractValidator<TRequest>> validators, 
            ILogger logger, 
            IMediator mediator,
            IHttpContextAccessor context,
            IRequestHandler<TRequest, TResponse> innerRequest
        )
        {
            this.validators = validators;
            this.logger = logger;
            this.mediator = mediator;
            this.context = context;
            this.traceId = context.HttpContext.TraceIdentifier;
            this.innerRequest = innerRequest;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            this.logger.Information($"{traceId} Processing a request {typeof(TRequest).Name}.");
            this.logger.Information($"{traceId} Request payload {request.ToJsonString(true)}.");

            string[] validationMessages = this.validators.Select(validator => {
                validator.CascadeMode = CascadeMode.Stop;
                return validator.Validate(request);
            })
            .Where(result => result.IsValid is false)
            .SelectMany(e => e.Errors.Select(err => err.ErrorMessage))
            .ToArray();

            if (validationMessages.Any() is false)
            {
                this.logger.Information($"{traceId} Validation errors found {validationMessages.ToJsonString(true)}");
                return new TResponse
                {
                    Response = "There were some validation errors.",
                    ValidationMessages = validationMessages,
                    TraceId = traceId
                };
            }

            var res = await this.innerRequest.Handle(request, cancellationToken);
            return null;
        }
    }
}
