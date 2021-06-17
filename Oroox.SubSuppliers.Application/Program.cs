using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Oroox.SubSuppliers.Core;
using System;
using System.IO;

namespace Oroox.SubSuppliers.Application
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                ConsoleUtilities.DisableQuickEditMode();

                IHost host = Host.CreateDefaultBuilder(args)
                    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                    .ConfigureWebHostDefaults(webHostBuilder =>
                    {
                        webHostBuilder
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseIISIntegration()
                            .UseStartup<Startup>();
                    })
                    .Build();

                host.Run();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
