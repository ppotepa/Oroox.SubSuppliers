using MailKit.Net.Smtp;
using MimeKit;
using Oroox.SubSuppliers.Domain.Entities;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public class ProductionMailingService : MailingServiceBase
    {
        public ProductionMailingService(ILogger logger) : base(logger) { }

        public override Task ConnectAndSend(MimeMessage message, CancellationToken cancelationToken)
        {
            throw new System.NotImplementedException();
        }

        public override Task SendNewCustomerRegistrationMessage(Customer customer, CancellationToken cancelationToken, string text = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
