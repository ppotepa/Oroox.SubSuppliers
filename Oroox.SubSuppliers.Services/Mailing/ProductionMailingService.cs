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
        public ProductionMailingService(ILogger logger, ISmtpClient client) : base(logger, client) { }

        public override Task ConnectAndSend(MimeMessage message, CancellationToken cancelationToken)
        {
            throw new System.NotImplementedException();
        }

        public override Task SendNewCustomerRegistrationMessage(Customer customer, CancellationToken cancelationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
