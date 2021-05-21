using Autofac;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Services.Mailing;

namespace Oroox.SubSuppliers.Services
{
    public class ServicesModule : Module
    {
        private readonly IConfiguration configuration;

        public ServicesModule(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            OxSuppliersEnvironmentVariables environmentVariables = configuration.GetEnvironmentVariables();

            builder
                .RegisterTypes(new[] { typeof(DevelopmentEmailService), typeof(ProductionMailingService) })
                .AsImplementedInterfaces()
                .OnActivating(args =>
                {
                    args.ReplaceInstance
                    (
                        environmentVariables.IsDevelopment
                            ? new DevelopmentEmailService(args.Context.Resolve<ILogger>(), new SmtpClient()) as IMailingService
                            : new ProductionMailingService(args.Context.Resolve<ILogger>(), new SmtpClient()) as IMailingService
                    );

                });

        }
    }
}
