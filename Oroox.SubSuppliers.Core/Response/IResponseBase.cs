using FluentValidation.Results;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Response
{
    public class ResponseBase
    {
        public ResponseBase() { }
        public IEnumerable<string> ValidationMessages { get; set; }
        public string Response { get; set; }
        public object Result { get; set; }
        
    }
}
