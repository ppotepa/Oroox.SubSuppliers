using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using System;

namespace Oroox.SubSuppliers.Core.Middleware.CorrelationId
{
    public static class CorrelationIdExtensions
    {
        public static IApplicationBuilder UseCorrelationId(this IApplicationBuilder app)
        {
            if (app is null)
                throw new ArgumentNullException(nameof(app));

            return app.UseMiddleware<CorrelationIdMiddleware>();
        }

        public static IApplicationBuilder UseCorrelationId(this IApplicationBuilder app, string header)
        {
            if (app is null) 
                throw new ArgumentNullException(nameof(app));

            return app.UseCorrelationId(new CorrelationIdOptions() { Header = header });
        }

        public static IApplicationBuilder UseCorrelationId(this IApplicationBuilder app, CorrelationIdOptions options)
        {
            if (app is null)
                throw new ArgumentNullException(nameof(app));
            if (options is null)
                throw new ArgumentNullException(nameof(options));

            return app.UseMiddleware<CorrelationIdMiddleware>(Options.Create(options));
        }

        public static string GetCorrelationId(this HttpRequest request)
        {
            return request.HttpContext.TraceIdentifier;
        }
    }
}
