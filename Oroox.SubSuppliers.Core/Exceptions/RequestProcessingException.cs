using System;
using System.Runtime.Serialization;

namespace Oroox.SubSuppliers.Exceptions
{
    [Serializable]
    internal class RequestProcessingException : Exception
    {
        public RequestProcessingException()
        {
        }

        public RequestProcessingException(string message) : base(message)
        {
        }

        public RequestProcessingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RequestProcessingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}