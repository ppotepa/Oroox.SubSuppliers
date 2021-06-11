using System.Collections.Generic;

namespace Oroox.SubSuppliers.Response
{
    public class BaseRespone
    {
        public BaseRespone() { }
        public IEnumerable<string> ValidationMessages { get; set; }
        public string Response { get; set; }
        public object Result { get; set; }
        public string TraceId { get; set; }
        public string RedirectUrl { get; set; }
    }
      
}
