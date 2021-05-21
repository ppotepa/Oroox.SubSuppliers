using Autofac;
using FluentValidation;
using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.RequestHandlers;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.User
{
    /// <summary>
    /// Autofac UsersModule
    /// </summary>
    public class CustomersModule : Module
    {
        private Type[] RequestTypes => ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IRequest<>))).ToArray();
        private Type[] Validators => ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IValidator<>))).ToArray();
        private Type[] Events => ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IEvent<>))).ToArray();
        private Type[] PreProcessors => ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IPreRequestProcessor<>))).ToArray();
        private Type[] PostProcessors => ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IPostRequestProcessor<>))).ToArray();

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomersController>().PropertiesAutowired();
            builder.RegisterType<SubSuppliersContext>().As<IApplicationContext>().InstancePerLifetimeScope();

            builder
                .RegisterTypes(Validators)
                .As(typeof(IValidator<>)
                .MakeGenericType(RequestTypes));

            builder
                .RegisterTypes(Events)
                .As(typeof(IEvent<>)
                .MakeGenericType(RequestTypes));

            builder
               .RegisterTypes(PreProcessors)
               .As(typeof(IPreRequestProcessor<>)
               .MakeGenericType(RequestTypes));

            builder
              .RegisterTypes(PostProcessors)
              .As(typeof(IPostRequestProcessor<>)
              .MakeGenericType(RequestTypes));

            base.Load(builder);
        }
    }
}
