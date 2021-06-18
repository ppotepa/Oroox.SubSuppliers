using System.Collections.Generic;

namespace Oroox.SubSuppliers.Response
{
    public class BaseResponse
    {
        public BaseResponse() { }
        public IEnumerable<string> ValidationMessages { get; set; }
        public string ResponseText { get; set; }
        public object Result { get; set; }
        public string TraceId { get; set; }
        public string RedirectUrl { get; set; }
    }
      
}
