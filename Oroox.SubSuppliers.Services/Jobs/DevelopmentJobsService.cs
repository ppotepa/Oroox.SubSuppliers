using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public class DevelopmentJobsService : IJobsService
    {
        private readonly IConfiguration configuration;

        public DevelopmentJobsService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private string[] PathParts => new string[]
        {
            Directory.GetCurrentDirectory(),
            "bin",
            "Debug",
            "netcoreapp3.1",
            "Jobs",
            "devjob.model.json"
        };

        private string JsonFileLocation => Path.Combine(PathParts);
        private string JsonFileText => File.ReadAllText(JsonFileLocation);
        public CalculationDetailsForQuote GetJobById(Guid jobId)
        {

            JObject jQuantities = JsonConvert.DeserializeObject<JObject>(JsonFileText);
            IList<JToken> tokens = new OldObject(jQuantities).ChildrenPublic;

            List<CalculationDetailsGroupMap> newStructure = tokens.Select(token =>
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
                            Sections = part?.First["Sections"]?.Select(x => 
                            {
                                var result = new CalculationDetailsSection
                                {
                                    Name = x?["Name"]?.Value<string>(),
                                    Details = x?["Details"].Select((section, sectionIndex) =>
                                    {
                                        var Class = section["Class"].Value<string>();
                                        var Value = section["Value"].Value<string>();
                                        var IsBold = section["IsBold"].Value<bool>();
                                        var ValueGroupType = (ValueGroupType) section["ValueGroupType"].Value<int>();
                                        var ValueType = (Domain.Entities.Job.Details.ValueType)section["ValueType"].Value<int>();
                                        var Name = section["Name"].Value<string>();
                                        var NumericValue = section["NumericValue"].Value<decimal>();
                                        var OperationType = (OperationType)section["OperationType"].Value<int>();
                                        var PriorityOrder = section["PriorityOrder"].Value<uint>();

                                        return new CalculationDetails
                                        {
                                            Class = Class,
                                            Value = Value,
                                            IsBold = IsBold,
                                            ValueGroupType = ValueGroupType,
                                            ValueType = ValueType,
                                            Name = Name,
                                            NumericValue = NumericValue,
                                            OperationType = OperationType,
                                            PriorityOrder = PriorityOrder
                                        };
                                    }).ToList()
                                };
                                return result;
                            }).ToList() ?? new List<CalculationDetailsSection>()
                        };
                    })
                    .ToList()
                };
                return map;
            })
            .ToList();

            return new CalculationDetailsForQuote
            {
                DetailsForQuantities = newStructure, 
                QuoteId = Guid.NewGuid()
            };
        }

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
