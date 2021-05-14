using Microsoft.AspNetCore.Http;

namespace Oroox.SubSuppliers.Utilities.Middleware.CorrelationId
{
    public class CorrelationIdOptions
    {
        public const string CorrelationIdHeaderName = "X-Correlation-ID";

        /// <summary>
        /// The header field name where the correlation ID will be stored
        /// </summary>
        public string Header { get; set; } = CorrelationIdHeaderName;

        /// <summary>
        /// Controls whether the correlation ID is returned in the response headers
        /// </summary>
        public bool IncludeInResponse { get; set; } = true;
    }
}
