namespace Oroox.SubSuppliers.RequestHandlers
{
    public interface IPreRequestHandler<in TRequest>
    {
        void Handle(TRequest request);
    }
    public interface IPostRequestHandler<in TRequest, in TResponse>
    {
        void Handle(TRequest request, TResponse response);
    }
    public interface IResponseHandler<in TResponse>
    {
        void Handle(TResponse response);
    }
}
