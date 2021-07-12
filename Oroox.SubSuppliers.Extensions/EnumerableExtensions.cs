using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oroox.SubSuppliers.Extensions
{
    public static class EnumerableExtensions
    {
    
        /// <summary>
        /// Allows using ForEach every Enumerable Collection.
        /// <br><b>Does not allow collections to be modified.</b></br>
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
        /// <summary>
        /// Extension method that allows obtaining multiple Validation messages from IEnumerable of Validator.
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <param name="validators"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string[] GetValidationMessages<TRequest>(this IEnumerable<IValidator<TRequest>> validators, TRequest request) where TRequest : IBaseRequest
            => validators.Select(validator => validator.Validate(request))
                            .Where(result => result.IsValid is false)
                            .SelectMany(e => e.Errors.Select(err => err.ErrorMessage))
                            .ToArray();


    }
}
