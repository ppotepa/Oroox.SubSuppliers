using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static string ToJsonString<TObject>(this TObject @object)
        {
            return JsonConvert.SerializeObject(@object);
        }
    }
}
