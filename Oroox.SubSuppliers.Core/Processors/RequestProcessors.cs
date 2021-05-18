namespace Oroox.SubSuppliers.Processors
{
    public interface IPreRequestProcessor<in TRequest>
    {
        void Handle(TRequest request);
    }
    public interface IPostRequestProcessor<in TRequest, in TResponse>
    {
        void Handle(TRequest request, TResponse response);
    }
    public interface IResponseProcessor<in TResponse>
    {
        void Handle(TResponse response);
    }
}
