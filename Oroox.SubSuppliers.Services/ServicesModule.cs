using Autofac;
using Autofac.Core.Resolving.Pipeline;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Services.Mailing;
using Serilog;
using System;

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
                .AsSelf();

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
        }
    }
}
