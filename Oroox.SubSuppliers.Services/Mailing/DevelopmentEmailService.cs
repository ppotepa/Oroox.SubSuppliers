using MailKit.Net.Smtp;
using MimeKit;
using Oroox.SubSuppliers.Domain.Entities;
using Serilog;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public class DevelopmentEmailService : MailingServiceBase
    {
        public DevelopmentEmailService(ILogger logger, ISmtpClient client) : base(logger, client) { }

        public async override Task ConnectAndSend(MimeMessage message)
        {
            this.client.Connect("smtp.gmail.com", 587, false);
            this.client.Authenticate("orooxlab", "grappaice69");
            await this.client.SendAsync(message);
        }

        public async override Task SendNewCustomerRegistrationMessage(Customer customer)
        {
            MimeMessage message = new MimeMessage
            {
                To = { InternetAddress.Parse("pawel.potepa@hotmail.com") },
                From = { InternetAddress.Parse("orooxlab@gmail.com") },
                Subject = "Test subject",
                Body = new TextPart("plain")
                {
                    Text = $@"Hello {customer.CompanyName},
                        Thank you for registration. 
                        Your activation code is : DUPA123
                    "
                }
            };

            await this.ConnectAndSend(message);
        }
       
    }
}
