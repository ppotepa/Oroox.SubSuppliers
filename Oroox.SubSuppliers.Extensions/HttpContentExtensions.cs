
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Extensions
{
    public static class HttpContentExtensions
    {
        public async static Task<TObjectType> ReadDeserializedObject<TObjectType>(this HttpContent @this) where TObjectType : class
        {
            string jsonString = await  @this.ReadAsStringAsync();
            TObjectType instance = JsonConvert.DeserializeObject<TObjectType>(jsonString);
            return instance;
        }
    }
}
