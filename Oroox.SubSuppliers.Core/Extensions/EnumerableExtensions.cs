using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<TObjectType>(IEnumerable<TObjectType> @this, Action<TObjectType> func) 
        {
            IEnumerator<TObjectType> enumerator = @this.GetEnumerator();
            while (enumerator.MoveNext())
            {
                func(enumerator.Current);
            }
        }
    }
}
