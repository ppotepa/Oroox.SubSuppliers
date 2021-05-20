using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Extensions
{
    public static class EnumerableExtensions
    {
    
        /// <summary>
        /// Allows using ForEach every Enumerable Collection.
        /// </summary>
        /// <typeparam name="TObjectType"></typeparam>
        /// <param name="this"></param>
        /// <param name="func"></param>
        public static void ForEach<TObjectType>(this IEnumerable<TObjectType> @this, Action<TObjectType> func) 
        {
            IEnumerator<TObjectType> enumerator = @this.GetEnumerator();
            while (enumerator.MoveNext())
            {
                func(enumerator.Current);
            }
        }

        /// <summary>
        /// Allows using ForEach on every Enumerable Collection. 
        /// This overload also allows to keep a track of current enumerator index.
        /// </summary>
        /// <typeparam name="TObjectType"></typeparam>
        /// <param name="this"></param>
        /// <param name="func"></param>
        /// <param name="index"></param>
        public static void ForEach<TObjectType>(this IEnumerable<TObjectType> @this, Action<TObjectType, int> func, int index = 0)
        {
            IEnumerator<TObjectType> enumerator = @this.GetEnumerator();
            while (enumerator.MoveNext())
            {
                func(enumerator.Current, index++);
            }
        }
    }
}
