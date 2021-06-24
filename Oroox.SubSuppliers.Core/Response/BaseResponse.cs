using System.Collections.Generic;

namespace Oroox.SubSuppliers.Response
{
    public abstract class BaseResponse
    {
        public BaseResponse() { }
        public IEnumerable<string> ValidationMessages { get; set; }
        public string ResponseText { get; set; }
        public string TraceId { get; set; }
        public string RedirectUrl { get; set; }
        public virtual dynamic Result
        {
            get => result;
            set => result = value;
        }
        protected object result;
    }

    public class BaseResponse<TModel> : BaseResponse where TModel : class
    {
        public new TModel Result
        {
            get => (TModel) result;
            set => result = value;
        }
    }
}
