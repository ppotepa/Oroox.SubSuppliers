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

            base.Load(builder);
        }
    }
}
