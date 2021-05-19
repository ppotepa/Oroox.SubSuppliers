using Newtonsoft.Json;

namespace Oroox.SubSuppliers.Utilities.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts an object to JObject
        /// Uses Newtonsoft.Json.
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="object"></param>
        /// <returns></returns>
        public static string ToJsonString<TObject>(this TObject @object, bool indent = false) =>
            JsonConvert.SerializeObject(@object, indent is true ? Formatting.Indented : Formatting.None);
    }
}
