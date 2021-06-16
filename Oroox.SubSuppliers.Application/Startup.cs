using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutofacSerilogIntegration;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Oroox.SubSuppliers.DependencyInjection;
using Oroox.SubSuppliers.Extensions;
using Oroox.SubSuppliers.Handlers;
using Oroox.SubSuppliers.Modules.Customers;
using Oroox.SubSuppliers.Modules.Jobs;
using Oroox.SubSuppliers.Services;
using Oroox.SubSuppliers.Utilities.Middleware.CorrelationId;
using Serilog;
using System.Linq;
using System.Reflection;

namespace Oroox.SubSuppliers.Application
{
    public class Startup 
    {
        private const string DevelopmentCORS = "DevelopmentCORS";
        private readonly IConfiguration Configuration;
        private readonly OxSuppliersEnvironmentVariables EnvironmentVariables;

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
            this.EnvironmentVariables = configuration.GetEnvironmentVariables();
        }

        public ILifetimeScope AutofacContainer { get; private set; }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment hostingEnvironment)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SubsuppliersPlatform API");
            });
            
            app.UseRouting();
            app.UseCors(DevelopmentCORS);
            
            app.UseMiddleware<CorrelationIdMiddleware>();
            app.UseMiddleware<TransactionMiddleware>();

            app.UseEndpoints(endpoints => endpoints.MapControllers());                        

            AutofacContainer = app.ApplicationServices.GetAutofacRoot();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            Assembly[] moduleAssemblies = new[]
            {
                typeof(CustomersModule).Assembly,
                typeof(JobsModule).Assembly,
            };

            builder.RegisterModule(new ServicesModule(Configuration));
            builder.RegisterModule(new AutoMapperModule(moduleAssemblies));
            builder.RegisterModule(new CustomersModule());

            builder.RegisterType<Mediator>().As<IMediator>().InstancePerDependency();

            builder.RegisterLogger();
            builder.RegisterMediatR(moduleAssemblies);

            builder.RegisterType<LoggerFactory>().As<ILoggerFactory>().InstancePerDependency();
            builder.RegisterGeneric(typeof(Logger<>)).As(typeof(ILogger<>)).InstancePerDependency();

            builder.RegisterGeneric(typeof(GenericHandlerDecorator<,>)).As(typeof(IPipelineBehavior<,>)).InstancePerDependency();
                
        }

        public void ConfigureServices(IServiceCollection services)
        {
            if (EnvironmentVariables.IsDevelopment)
            {
                services.AddCors(options =>
                {
                    options.AddPolicy(name: DevelopmentCORS,
                    builder =>
                    {
                        builder.WithOrigins(new string[] { "http://localhost:4200" })
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowCredentials();
                    });
                });
            }

            services.AddOptions();
            services.AddSwaggerGen(x => x.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()));
            services.AddHttpContextAccessor();   
           
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;                
            })
            .AddControllersAsServices();

            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
        }
    }
}
