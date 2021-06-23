using MailKit.Net.Smtp;
using MediatR;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Oroox.SubSuppliers.Domain.Entities;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public class DevelopmentEmailService : MailingServiceBase
    {
        private readonly IConfiguration configuration;
        public DevelopmentEmailService(ILogger logger, IConfiguration configration) : base(logger) 
        {
            this.configuration = configration;
        }

        private (string smtp, int port, bool useSsl) DEVELOPMENT_SERVER_CREDENTIALS = 
        (
            smtp: "smtp.gmail.com", 
            port: 587, 
            useSsl: false
        );

        protected async override Task<Unit> ConnectAndSend(MimeMessage message, CancellationToken cancelationToken)
        {
            using (this.client = new SmtpClient())
            {
                await client.ConnectAsync
                (
                    DEVELOPMENT_SERVER_CREDENTIALS.smtp,
                    DEVELOPMENT_SERVER_CREDENTIALS.port,
                    DEVELOPMENT_SERVER_CREDENTIALS.useSsl
                );
                await client.AuthenticateAsync("orooxlab", "grappaice69");
                await client.SendAsync(message);
                await client.DisconnectAsync(true, cancelationToken);
            }

            return await Unit.Task;
        }

        public async override Task<Unit> SendNewCustomerRegistrationMessage(Customer customer, CancellationToken cancelationToken, string messageText = null)
        {
            MimeMessage message = new MimeMessage
            {
                To = { InternetAddress.Parse(customer.EmailAddress) },
                From = { InternetAddress.Parse("pawel.potepa@hotmail.com") },
                Subject = "Test subject",
                Body = new TextPart("plain")
                {
                    Text = messageText is null ? $@"Hello {customer.CompanyName},
                        Thank you for registration. 
                        Your activation code is : https://localhost:5001/api/customers/activate?Registration.ActivationCode={customer.Registration.ActivationCode}"
                    : messageText
                }
            };

            await this.ConnectAndSend(message, cancelationToken);
            return await Unit.Task;
        }

        public async override Task<Unit> SendNewSharedJobNotification(Customer customer, Job job, SharedJob sharedJob, CancellationToken cancelationToken, string messageText = null)
        {
            MimeMessage message = new MimeMessage
            {
                To = { InternetAddress.Parse(customer.EmailAddress) },
                From = { InternetAddress.Parse("pawel.potepa@hotmail.com") },
                Subject = "New job was shared!",
                Body = new TextPart("plain")
                {
                    Text = messageText is null ? $@"Hello, {customer.CompanyName} a new Job with id {job.Id} was just shared with you."
                     : messageText
                }
            };

            await this.ConnectAndSend(message, cancelationToken);
            return await Unit.Task;
        }
    }
}
