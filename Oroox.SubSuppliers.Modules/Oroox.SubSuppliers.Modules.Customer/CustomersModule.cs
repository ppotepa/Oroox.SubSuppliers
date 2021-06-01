using Autofac;
using FluentValidation;
using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.Processors;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.Customers
{
    /// <summary>
    /// Autofac UsersModule
    /// </summary>
    public class CustomersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomersController>().PropertiesAutowired();            

            Type[] Validators = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IValidator<>))).ToArray();
            Type[] Events = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IEvent<>))).ToArray();
            Type[] PreProcessors = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IPreRequestProcessor<>))).ToArray();
            Type[] PostProcessors = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IPostRequestProcessor<>))).ToArray();

            builder.RegisterTypes(Validators).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterTypes(Events).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterTypes(PreProcessors).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterTypes(PostProcessors).AsImplementedInterfaces().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
