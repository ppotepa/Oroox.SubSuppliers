using FluentValidation.Results;
using MediatR;


namespace Oroox.SubSuppliers.Validation
{
    /// <summary>
    /// Request Validator Interface.
    /// <br>When any Entity related request is being handled it is being injected as IEnumerable to Generic Controller</br>
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    public interface IRequestValidator<in TRequest> where TRequest : IBaseRequest
    {
        ValidationResult Process(TRequest request);
    }
}
