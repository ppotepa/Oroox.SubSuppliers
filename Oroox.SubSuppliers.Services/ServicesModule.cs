using Autofac;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Services.Jobs;
using Oroox.SubSuppliers.Services.Mailing;

namespace Oroox.SubSuppliers.Services
{
    public class ServicesModule : Module
    {
        private readonly IConfiguration configuration;
        private bool IsDevelopment => configuration.GetEnvironmentVariables().IsDevelopment;
        public ServicesModule(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<SubSuppliersContext>().As<IApplicationContext>().InstancePerLifetimeScope();

            builder
                .RegisterType<SmtpClient>()
                .AsImplementedInterfaces();

            builder
                .RegisterTypes(new[] { typeof(DevelopmentEmailService), typeof(ProductionMailingService) })
                .AsImplementedInterfaces()
                .OnActivating
                (
                    args => 
                    {
                        IMailingService instance = IsDevelopment is true 
                            ? args.Context.Resolve<DevelopmentEmailService>()
                            : args.Context.Resolve<ProductionMailingService>() as IMailingService;

                        args.ReplaceInstance(instance);
                    }
                );

            builder
                .RegisterTypes(new[] { typeof(DevelopmentJobsService), typeof(ProductionJobsService) })
                .AsImplementedInterfaces()
                .OnActivating
                (
                    args =>
                    {
                        IJobsService instance = IsDevelopment is true
                            ? args.Context.Resolve<DevelopmentEmailService>() as IJobsService
                            : args.Context.Resolve<ProductionJobsService>();

                        args.ReplaceInstance(instance);
                    }
                );

        }
    }
}
