using System;
using System.Reflection;

namespace Oroox.SubSuppliers.Utilities.Abstractions
{
    public abstract class SubSuppliersModule : Autofac.Module
    {
        protected override Assembly ThisAssembly => Assembly.GetCallingAssembly();
    }
}
