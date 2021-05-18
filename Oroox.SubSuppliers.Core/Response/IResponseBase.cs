namespace Oroox.SubSuppliers.Response
{
    public class ResponseBase
    {
        public ResponseBase() { }
        public string ValidationMessage { get; set; }
        public string Response { get; set; }
        public object Result { get; set; }
        
    }
}
