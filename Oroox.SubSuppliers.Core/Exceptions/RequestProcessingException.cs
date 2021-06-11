using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Oroox.SubSuppliers.Exceptions
{
    [Serializable]
    public class RequestProcessingException : Exception
    {
        public RequestProcessingException()
        {
        }

        public RequestProcessingException(string message) : base(message) { }
        public RequestProcessingException(string message, IBaseRequest request, Exception innerException) : base(message, innerException) 
        {
            this.Data.Add("RequestData", request);
        }
      
        public RequestProcessingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RequestProcessingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}