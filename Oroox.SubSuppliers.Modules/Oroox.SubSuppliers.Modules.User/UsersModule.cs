using Autofac;
using FluentValidation;
using MediatR;
using Oroox.SubSuppliers.Domain;
using Oroox.SubSuppliers.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.User
{
    /// <summary>
    /// Autofac UsersModule
    /// </summary>
    public class UsersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            List<Type> requestTypes = this.ThisAssembly.GetTypes().Where(type => type.IsClosedTypeOf(typeof(IRequest<>))).ToList();

            requestTypes.ForEach(requestType =>
            {
                Type requestResult = requestType.GetInterfaces().First().GetGenericArguments().First();
                Type pipelineType = typeof(GenericPipeline<,>).MakeGenericType(requestType, requestResult);
                List<Type> validators = ThisAssembly.GetTypes().Where(t => t.IsClosedTypeOf(typeof(AbstractValidator<>))).ToList();

                validators.ForEach(validator =>
                {
                    builder.RegisterType(validator).As(typeof(AbstractValidator<>).MakeGenericType(requestType));
                });

                builder.RegisterType(pipelineType).AsImplementedInterfaces().InstancePerDependency().PropertiesAutowired();
            });

            builder
                .RegisterType<SubSuppliersContext>()
                .AsImplementedInterfaces()
                .InstancePerDependency();

            base.Load(builder);
        }
    }
}
