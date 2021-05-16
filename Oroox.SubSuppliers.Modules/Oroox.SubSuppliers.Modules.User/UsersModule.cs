using Autofac;
using Oroox.SubSuppliers.Domain;

namespace Oroox.SubSuppliers.Modules.User
{
    public class UsersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<SubSuppliersContext>()
                .AsImplementedInterfaces()
                .InstancePerDependency();

            base.Load(builder);
        }
    }
}
