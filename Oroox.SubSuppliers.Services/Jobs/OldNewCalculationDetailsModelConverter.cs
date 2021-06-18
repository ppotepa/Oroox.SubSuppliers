using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using ValueType = Oroox.SubSuppliers.Domain.Entities.Job.Details.ValueType;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public class OldNewCalculationDetailsModelConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            JObject @object = JObject.Load(reader).GetValue("detailsForQuantities") as JObject;
            IList<JToken> tokens = new OldObject(@object).ChildrenPublic;

            List<CalculationDetailsGroupMap> newCalculationDetails = tokens.Select(token =>
            {
                CalculationDetailsGroupMap map = new CalculationDetailsGroupMap
                {
                    Quantity = (uint)Convert.ToInt32(token.Path),
                    Details = token?.First["Details"]?.ToArray().Select((part, partIndex) =>
                    {
                        Console.WriteLine(part.Path);

                        return new CalculationDetailsGroup
                        {
                            PartIndex = partIndex,
                            Name = part.First["Name"].Value<object>().ToString(),
                            Sections = part?.First["Sections"]?.Select(section =>
                            {
                                CalculationDetailsSection result = new CalculationDetailsSection
                                {
                                    Name = section["Name"]?.Value<string>(),
                                    Details = section["Details"].Select((section, sectionIndex) =>
                                    {
                                        return new CalculationDetails
                                        {
                                            Class = section["Class"].Value<string>(),
                                            Value = section["Value"].Value<string>(),
                                            IsBold = section["IsBold"].Value<bool>(),
                                            ValueGroupType = (ValueGroupType)section["ValueGroupType"].Value<int>(),
                                            ValueType = (ValueType)section["ValueType"].Value<int>(),
                                            Name = section["Name"].Value<string>(),
                                            NumericValue = section["NumericValue"].Value<decimal>(),
                                            OperationType = (OperationType)section["OperationType"].Value<int>(),
                                            PriorityOrder = section["PriorityOrder"].Value<uint>()
                                        };

                                    }).ToList() ?? new List<CalculationDetails>()
                                };
                                return result;
                            })
                            .ToList() ?? new List<CalculationDetailsSection>()
                        };
                    })
                    .ToList() ?? new List<CalculationDetailsGroup>()
                };
                return map;
            }).ToList();

            CalculationDetailsForQuote details = new CalculationDetailsForQuote
            {
                DetailsForQuantities = newCalculationDetails,
            };

            return details;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        /// <summary>
        /// Helper class in order to expose children tokens.
        /// </summary>
        class OldObject : JObject
        {
            public OldObject(JObject other) : base(other)
            {

            }


            public IList<JToken> ChildrenPublic
                => this.ChildrenTokens;

        }
    }
}