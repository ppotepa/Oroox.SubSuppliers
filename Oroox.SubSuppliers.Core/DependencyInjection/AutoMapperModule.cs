using Autofac;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Oroox.SubSuppliers.DependencyInjection
{
    public class AutoMapperModule : Autofac.Module
    {
        private readonly IEnumerable<Assembly> assemblies;
        public AutoMapperModule(IEnumerable<Assembly> assemblies)
        {
            this.assemblies = assemblies;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            Assembly[] assembliesToScan = this.assemblies as Assembly[] ?? this.assemblies.ToArray();
            builder.Register<IConfigurationProvider>(ctx => new MapperConfiguration(configuration => configuration.AddMaps(assembliesToScan))).SingleInstance();
            builder.Register<IMapper>(context => new Mapper(context.Resolve<IConfigurationProvider>(), context.Resolve)).InstancePerDependency();
        }
    }
}
