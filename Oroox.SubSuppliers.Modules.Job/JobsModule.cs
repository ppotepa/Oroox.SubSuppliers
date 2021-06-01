using Autofac;

namespace Oroox.SubSuppliers.Modules.Jobs
{
    /// <summary>
    /// Autofac UsersModule
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
