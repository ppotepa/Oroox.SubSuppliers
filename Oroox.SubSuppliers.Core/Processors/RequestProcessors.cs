namespace Oroox.SubSuppliers.Processors
{
    ///// <summary>
    ///// Pre Request Processor
    ///// <br>Is being injected as IEnumerable into GenericRequestHandler.</br>
    ///// <br>Allows Pre Processing Requests.</br>
    ///// </summary>
    ///// <typeparam name="TRequest"></typeparam>
    //public interface IPreRequestProcessor<in TRequest>
    //{
    //    void Handle(TRequest request);
    //}
    ///// <summary>
    ///// Post Request Processor
    ///// <br>Is being injected as IEnumerable into GenericRequestHandler.</br>
    ///// <br>Allows Post Processing Requests.</br>
    ///// </summary>
    ///// <typeparam name="TRequest"></typeparam>
    //public interface IPostRequestProcessor<in TRequest, in TResponse>
    //{
    //    void Handle(TRequest request, TResponse response);
    //}

    ///// <summary>
    ///// Response Request Processor 
    ///// <br>Is being injected as IEnumerable into GenericRequestHandler.</br>
    ///// <br>Allows Pre Processing Requests.</br>
    ///// <br><b>Currently not being used.</b></br>
    ///// </summary>
    ///// <typeparam name="TRequest"></typeparam>
    //public interface IResponseProcessor<in TResponse>
    //{
    //    void Handle(TResponse response);
    //}
}
