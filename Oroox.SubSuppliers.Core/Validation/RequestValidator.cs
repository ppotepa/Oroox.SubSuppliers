using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Serilog;

namespace Oroox.SubSuppliers.Validation
{
    /// <summary>
    /// Request Validator.
    /// <br>When any Entity related request is being handled it is being injected as IEnumerable to Generic Controller</br>
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    public abstract class RequestValidator<TRequestType> : AbstractValidator<TRequestType>, IRequestValidator<TRequestType>
        where TRequestType : IBaseRequest
    {
        public ValidationResult Process(TRequestType request) => this.Validate(request);
    }
}
