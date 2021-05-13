using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutofacSerilogIntegration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Oroox.SubSuppliers.Modules.User;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.ApplicationTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; private set; }
        public ILifetimeScope AutofacContainer { get; private set; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();            
            services.AddMvc().AddControllersAsServices();             
        }
     
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new UsersModule());
            builder.RegisterType<UsersController>().PropertiesAutowired();
            builder.RegisterLogger();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            app.UseRouting();
            app.UseEndpoints(x => 
            {
                x.MapControllers();                
            });

            AutofacContainer = app.ApplicationServices.GetAutofacRoot();          
        }
    }
}
