using System;
using System.Collections.Generic;
using System.Linq;

namespace Oroox.SubSuppliers.Domain.Utilities
{
    public static class EnumerationUtility
    {
        private const string EnumerationClassName = "EnumerationEntity`1";
        public static Type[] GetCurrentAssemblyEnumerations() 
            =>   AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes())           
                    .Where(type => type.GetInterfaces().Contains(typeof(IEnumerationEntity)) && type.Name != EnumerationClassName)
                    .ToArray();

        public static Type[] GetCurrentAssemblyEnumerationTypes() 
            => GetCurrentAssemblyEnumerations()
                .Select(entity => entity.BaseType.GenericTypeArguments.First())
                .ToArray();

        public static Dictionary<string, Type> GetEnumerationsTypeMap()
           => AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes())
                   .Where(type => type.GetInterfaces().Contains(typeof(IEnumerationEntity)) && type.Name != EnumerationClassName)
                   .ToDictionary(x => x.BaseType.GenericTypeArguments.First().Name, x => x);
    }
}
