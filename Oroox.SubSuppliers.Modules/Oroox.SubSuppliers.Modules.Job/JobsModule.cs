using Autofac;

namespace Oroox.SubSuppliers.Modules.Jobs
{
    /// <summary>
    /// Autofac JobsModule
    /// </summary>
    public class JobsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<JobsController>().PropertiesAutowired();
            base.Load(builder);
        }
    }
}
