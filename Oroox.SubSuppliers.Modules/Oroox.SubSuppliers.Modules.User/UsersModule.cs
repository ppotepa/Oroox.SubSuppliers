using Autofac;
using MediatR;
using Oroox.SubSuppliers.Domain;
using Oroox.SubSuppliers.Modules.User.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oroox.SubSuppliers.Modules.User
{
    public class UsersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            List<Type> requestTypes = this.ThisAssembly.GetTypes()
                .Where(type => type.IsClosedTypeOf(typeof(IRequest<>)))
                .ToList();

            requestTypes.ForEach(request => 
            {
                //MediatR.IRequestHandler`2[Oroox.SubSuppliers.Modules.User.Requests.CreateCustomerRequest,Oroox.SubSuppliers.Modules.User.Requests.CreateCusto
                Type requestResult = request.GetInterfaces().First().GetGenericArguments().First();
                Type pipelineType = typeof(GenericPipeline<,>).MakeGenericType(new[] { request, requestResult });
                Type targetHandlerType = typeof(IRequestHandler<,>).MakeGenericType(new[] { request, requestResult });
                Type testType = new GenericPipeline<CreateCustomerRequest, CreateCustomerRequestResponse>().GetType().GetInterfaces().First();
                bool areEqual = targetHandlerType == testType;
                builder.RegisterType(pipelineType);
            });

            builder
                .RegisterType<SubSuppliersContext>()
                .AsImplementedInterfaces()
                .InstancePerDependency();

            base.Load(builder);
        }
    }
}
