using Autofac;
using FluentValidation;
using MediatR.Pipeline;
using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.Utilities.Abstractions;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Customers
{
    /// <summary>
    /// Autofac UsersModule
    /// </summary>
    public class CustomersModule : SubSuppliersModule
    {
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomersController>().PropertiesAutowired();

            Type[] Validators = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IValidator<>))).ToArray();
            Type[] Events = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IEvent<>))).ToArray();
            Type[] PreProcessors = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IRequestPreProcessor<>))).ToArray();
            Type[] PostProcessors = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IRequestPostProcessor<,>))).ToArray();

            builder.RegisterTypes(Validators).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterTypes(Events).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterTypes(PreProcessors).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterTypes(PostProcessors).AsImplementedInterfaces().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
