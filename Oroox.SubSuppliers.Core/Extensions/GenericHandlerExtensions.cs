using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Oroox.SubSuppliers.Extensions
{
    public static class GenericHandlerExtensions
    {
        public static IEnumerable<string> GetValidationMessages(this IEnumerable<ValidationResult> @this) 
            => @this.Where(failure => failure != null)
                    .SelectMany(v => v.Errors)
                    .Select(f => f.ErrorMessage);

    }
}
