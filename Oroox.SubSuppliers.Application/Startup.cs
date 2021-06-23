using Autofac;
using Autofac.Core;
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
using Oroox.SubSuppliers.Services;
using Oroox.SubSuppliers.Utilities.Abstractions;
using Oroox.SubSuppliers.Utilities.Middleware.CorrelationId;
using Serilog;
using System;
using System.Linq;
using System.Reflection;

namespace Oroox.SubSuppliers.Application
{
    public class Startup 
    {
        private const string DevelopmentCORS = "DevelopmentCORS";
        private readonly IConfiguration configuration;
        private readonly OxSuppliersEnvironmentVariables EnvironmentVariables;
        private static readonly Type[] AutofacModules = AppDomain.CurrentDomain
                                                .GetAssemblies()
                                                .SelectMany(a => a.GetTypes())
                                                .Where(type => type.IsSubclassOf(typeof(SubSuppliersModule)))
                                                .ToArray();


        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
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
            Assembly[] moduleAssemblies = AutofacModules.Select(module => module.Assembly).ToArray();

            builder.RegisterModule(new ServicesModule(configuration));

            AutofacModules.ForEach(module => 
            {
                builder.RegisterModule(Activator.CreateInstance(module) as IModule);
            });

            builder.RegisterType<Mediator>().As<IMediator>().InstancePerDependency();
            builder.RegisterModule(new AutoMapperModule(moduleAssemblies));
            builder.RegisterMediatR(moduleAssemblies);

            builder.RegisterLogger();

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
