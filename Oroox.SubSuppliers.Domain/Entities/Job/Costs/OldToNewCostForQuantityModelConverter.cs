using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public class OldToNewCostForQuantityModelConverter : JsonConverter
    {
        public override bool CanConvert(Type typeToConvert)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Dictionary<uint, decimal> jObject = JObject.Load(reader).ToObject<Dictionary<uint, decimal>>();
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}