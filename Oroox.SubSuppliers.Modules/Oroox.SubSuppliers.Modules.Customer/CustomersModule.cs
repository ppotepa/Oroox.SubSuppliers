using Autofac;
using FluentValidation;
using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Event;
using Oroox.SubSuppliers.Handlers;
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
            builder.RegisterType<SubSuppliersContext>().As<IApplicationContext>().InstancePerLifetimeScope();
            Type[] RequestTypes = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IRequest<>))).ToArray();

            RequestTypes.ToList().ForEach(request => 
            {
                Type[] Validators = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IValidator<>))).ToArray();
                Type[] Events = ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IEvent<>))).ToArray();

                Type[] PreProcessors = ThisAssembly
                .GetTypes()
                .Where(type => type.GetInterfaces().Contains(typeof(IPreRequestProcessor<>)
                .MakeGenericType(request)))
                .ToArray();

                Type[] PostProcessors = ThisAssembly
                .GetTypes()
                .Where(type => type.GetInterfaces().Contains(typeof(IPostRequestProcessor<>)
                .MakeGenericType(request)))
                .ToArray();

                builder
                    .RegisterTypes(Validators)
                    .As(typeof(IValidator<>)
                    .MakeGenericType(request));

                builder
                    .RegisterTypes(Events)
                    .As(typeof(IEvent<>)
                    .MakeGenericType(request));

                builder
                   .RegisterTypes(PreProcessors)
                   .As(typeof(IPreRequestProcessor<>)
                   .MakeGenericType(request));

                builder
                  .RegisterTypes(PostProcessors)
                  .As(typeof(IPostRequestProcessor<>)
                  .MakeGenericType(request));
            });

            base.Load(builder);
        }
    }
}
