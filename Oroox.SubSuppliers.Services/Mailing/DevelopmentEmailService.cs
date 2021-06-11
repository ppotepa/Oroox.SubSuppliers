using MailKit.Net.Smtp;
using MimeKit;
using Oroox.SubSuppliers.Domain.Entities;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public class DevelopmentEmailService : MailingServiceBase
    {
        public DevelopmentEmailService(ILogger logger) : base(logger) { }

        public async override Task ConnectAndSend(MimeMessage message, CancellationToken cancelationToken)
        {
            using (this.client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("orooxlab", "grappaice69");
                await client.SendAsync(message);
                await client.DisconnectAsync(true, cancelationToken);
            }
        }

        public async override Task SendNewCustomerRegistrationMessage(Customer customer, CancellationToken cancelationToken, string text = null)
        {
            MimeMessage message = new MimeMessage
            {
                To = { InternetAddress.Parse(customer.EmailAddress) },
                From = { InternetAddress.Parse("pawel.potepa@hotmail.com") },
                Subject = "Test subject",
                Body = new TextPart("plain")
                {
                    Text = text is null ? $@"Hello {customer.CompanyName},
                        Thank you for registration. 
                        Your activation code is : https://localhost:5001/api/customers/activate?Registration.ActivationCode={customer.Registration.ActivationCode},
                    " : text
                }
            };

            await this.ConnectAndSend(message, cancelationToken);
        }
    }
}
