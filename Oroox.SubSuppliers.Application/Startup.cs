using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutofacSerilogIntegration;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Oroox.SubSuppliers.DependencyInjection;
using Oroox.SubSuppliers.Domain;
using Oroox.SubSuppliers.Modules.User;
using Oroox.SubSuppliers.Utilities.Middleware.CorrelationId;
using Serilog;
using System.Reflection;

namespace Oroox.SubSuppliers.Application
{
    public class Startup 
    {
        private readonly IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ILifetimeScope AutofacContainer { get; private set; }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SubsuppliersPlatform API");
            });

            app.UseMiddleware<CorrelationIdMiddleware>();
            app.UseRouting();
            app.UseEndpoints(builder => builder.MapControllers());

            AutofacContainer = app.ApplicationServices.GetAutofacRoot();
        }

        public interface IMail { }
        public class Mail : IMail { };

        public void ConfigureContainer(ContainerBuilder builder)
        {
            Assembly[] moduleAssemblies = new[] 
            {
                typeof(UsersModule).Assembly
            };

            builder.RegisterModule(new AutoMapperModule(moduleAssemblies));
            builder.RegisterModule(new UsersModule());

            builder.RegisterType<Mediator>().As<IMediator>().InstancePerDependency();
            builder.RegisterType<CustomersController>().PropertiesAutowired();
            builder.RegisterType<SubSuppliersContext>().AsSelf().InstancePerDependency();

            builder.RegisterLogger();
            builder.RegisterMediatR(moduleAssemblies);

            builder.RegisterType<LoggerFactory>()
                .As<ILoggerFactory>()
                .InstancePerDependency();

            builder
                .RegisterGeneric(typeof(Logger<>))
                .As(typeof(ILogger<>))
                .InstancePerDependency();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddSwaggerGen();
            services.AddHttpContextAccessor();

            services.AddMvc().AddNewtonsoftJson(options =>
            {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            })
            .AddControllersAsServices();
            
            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
        }
    }
}
