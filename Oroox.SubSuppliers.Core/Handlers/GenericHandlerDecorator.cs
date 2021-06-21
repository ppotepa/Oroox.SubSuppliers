using FluentValidation;
using MediatR;
using MediatR.Pipeline;
using Microsoft.AspNetCore.Http;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.Exceptions;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Response;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Handlers
{
    /// <summary>
    /// Generic Pipeline works is Registered as Generic Decorator
    /// <br>Used as a main pipeline in request handling process.</br>
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public sealed class GenericHandlerDecorator<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : BaseResponse, new()
    {

        private readonly IApplicationContext context;
        private readonly IEnumerable<IEvent<TRequest>> events;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IRequestHandler<TRequest, TResponse> innerRequest;
        private readonly ILogger logger;
        private readonly IEnumerable<IRequestPostProcessor<TRequest, TResponse>> postProcessors;
        private readonly IEnumerable<IRequestPreProcessor<TRequest>> preProcessors;
        private readonly IEnumerable<IValidator<TRequest>> validators;
        public GenericHandlerDecorator
        (
            IEnumerable<IValidator<TRequest>> validators,
            IEnumerable<IRequestPreProcessor<TRequest>> preProcessors,
            IEnumerable<IRequestPostProcessor<TRequest, TResponse>> postProcessors,
            IEnumerable<IEvent<TRequest>> events,
            IHttpContextAccessor httpContextAccessor,
            IRequestHandler<TRequest, TResponse> innerRequest,
            IApplicationContext context,
            ILogger logger
        )
        {
            this.validators = validators;
            this.preProcessors = preProcessors;
            this.postProcessors = postProcessors;
            this.httpContextAccessor = httpContextAccessor;
            this.logger = logger;
            this.events = events;
            this.innerRequest = innerRequest;
            this.context = context;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            TResponse response = default;

            try
            {
                this.logger.Information($"Processing a request {typeof(TRequest).Name}.");
                this.preProcessors.ForEach(processor => processor.Process(request, cancellationToken));

                string[] validationMessages = this.validators.GetValidationMessages(request);

                if (validationMessages.Any() is true)
                {
                    return new TResponse
                    {
                        ResponseText = "There were some validation errors.",
                        ValidationMessages = validationMessages
                    };
                }

                response = await this.innerRequest.Handle(request, cancellationToken);
                this.postProcessors.ForEach(processor => processor.Process(request, response, cancellationToken));
                await context.SaveChangesAsync(true, cancellationToken);
            }
            catch (Exception exception)
            {
                throw new RequestProcessingException
                (
                    message:    $"Error processing request with id {httpContextAccessor.HttpContext.TraceIdentifier}. " +
                                $"See Data to provide better view.",

                    request: request,
                    innerException: exception
                );
            }

            events.ForEach(@event => @event.Handle(request, cancellationToken));
            return response;
        }
    }
}
