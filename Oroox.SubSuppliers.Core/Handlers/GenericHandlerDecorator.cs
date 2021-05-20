﻿using FluentValidation;
using MediatR;
using Oroox.SubSuppliers.Domain;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Response;
using Serilog;
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
    public sealed class GenericHandlerDecorator<TRequest, TResponse> :  IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : ResponseBase, new()
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;        
        private readonly IRequestHandler<TRequest, TResponse> innerRequest;
        private readonly IApplicationContext context;
        private readonly ILogger logger;

        public GenericHandlerDecorator
        (
            IEnumerable<IValidator<TRequest>> validators, 
            IRequestHandler<TRequest, TResponse> innerRequest,
            IApplicationContext context,
            ILogger logger
        )
        {
            this.validators = validators;
            this.logger = logger;
            this.innerRequest = innerRequest;
            this.context = context;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            this.logger.Information($"Processing a request {typeof(TRequest).Name}.");

            string[] validationMessages = this.validators.Select(validator => validator.Validate(request))
            .Where(result => result.IsValid is false)
            .SelectMany(e => e.Errors.Select(err => err.ErrorMessage))
            .ToArray();

            if (validationMessages.Any() is true)
            {
                return new TResponse
                {
                    Response = "There were some validation errors.",
                    ValidationMessages = validationMessages
                };
            }

            TResponse response = await this.innerRequest.Handle(request, cancellationToken);
            return response;
        }
    }
}