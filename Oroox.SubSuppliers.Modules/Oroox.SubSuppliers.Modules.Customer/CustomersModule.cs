using Autofac;
using FluentValidation;
using MediatR;
using Oroox.SubSuppliers.Domain.Context;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.User
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

            Type[] requestTypes = this.ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IRequest<>))).ToArray();
            Type[] validators = ThisAssembly.GetTypes().Where(t => t.IsClosedTypeOf(typeof(IValidator<>))).ToArray();

            builder.RegisterTypes(validators)
                .As(typeof(IValidator<>)
                .MakeGenericType(requestTypes));

            base.Load(builder);
        }
    }
}
