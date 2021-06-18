using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var readerLoaded = JObject.Load(reader);

            Console.WriteLine("existing value: " + readerLoaded.ToString());
            List<CostPerQuantity> result = readerLoaded.ToObject<Dictionary<uint, decimal>>()
                    .Select(kvp => new CostPerQuantity { Quantity = kvp.Key, Cost = kvp.Value })
                    .ToList();

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}