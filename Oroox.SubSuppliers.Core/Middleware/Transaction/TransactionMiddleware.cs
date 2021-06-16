using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Transactions;

namespace Oroox.SubSuppliers.Utilities.Middleware.CorrelationId
{
    /// <summary>
    /// Works as an Request Interceptor.
    /// Allows for request to return current TraceIdentifier.
    /// </summary>
    public class TransactionMiddleware
    {
        private readonly RequestDelegate next = default;        

        public TransactionMiddleware(RequestDelegate next, IOptions<CorrelationIdOptions> options)
        {
            this.next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext context)
        {
            TransactionOptions transactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TransactionManager.MaximumTimeout
            };

            using (var transaction = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await next(context);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                transaction.Complete();
            }
        }
    }
}
 