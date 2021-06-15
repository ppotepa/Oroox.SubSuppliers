using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Oroox.SubSuppliers.Core;
using System.IO;
using System.Threading;

namespace Oroox.SubSuppliers.Application
{
    public partial class Program
    {
        public static void Main(string[] args)
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
    }
}
