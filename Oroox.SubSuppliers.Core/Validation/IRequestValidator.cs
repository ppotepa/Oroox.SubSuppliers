using FluentValidation.Results;
using MediatR;


namespace Oroox.SubSuppliers.Validation
{
    public interface IRequestValidator<in TRequest> where TRequest : IBaseRequest
    {
        ValidationResult Process(TRequest request);
    }
}
