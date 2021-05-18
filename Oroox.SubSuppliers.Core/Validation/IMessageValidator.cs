using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Oroox.SubSuppliers.Validation
{
    public class ValidationFailure 
    {
        public ValidationResult[] Errors { get; set; }
    }

    public interface IMessageValidator<in TMessage>
    {
        IEnumerable<ValidationFailure> Validate(TMessage message);
    }
}
