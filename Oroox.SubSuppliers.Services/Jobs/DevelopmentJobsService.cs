using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities.Job.Details;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ValueType = Oroox.SubSuppliers.Domain.Entities.Job.Details.ValueType;

namespace Oroox.SubSuppliers.Services.Jobs
{
    public class DevelopmentJobsService : IJobsService
    {
        private readonly IConfiguration configuration;
        private readonly IApplicationContext context;        

        public DevelopmentJobsService(IConfiguration configuration, IApplicationContext context)
        {
            this.configuration = configuration;
            this.context = context;
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

        public  async Task<CalculationDetailsForQuote> RetrieveJobFromOxQuoteApp(Guid jobId, CancellationToken cancelationToken)
        {
            JObject jQuantities = JsonConvert.DeserializeObject<JObject>(JsonFileText);
            IList<JToken> tokens = new OldObject(jQuantities).ChildrenPublic;
            
            List<CalculationDetailsGroupMap> newStructure = tokens.Select(token =>
            {
                CalculationDetailsGroupMap map = new CalculationDetailsGroupMap
                {
                    Quantity = (uint) Convert.ToInt32(token.Path),
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
                                        string Class = section["Class"].Value<string>();
                                        string Value = section["Value"].Value<string>();
                                        bool IsBold = section["IsBold"].Value<bool>();
                                        ValueGroupType ValueGroupType = (ValueGroupType)section["ValueGroupType"].Value<int>();
                                        ValueType ValueType = (ValueType)section["ValueType"].Value<int>();
                                        string Name = section["Name"].Value<string>();
                                        decimal NumericValue = section["NumericValue"].Value<decimal>();
                                        OperationType OperationType = (OperationType)section["OperationType"].Value<int>();
                                        uint PriorityOrder = section["PriorityOrder"].Value<uint>();

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

            var details = new CalculationDetailsForQuote
            {
                DetailsForQuantities = newStructure,                
            };

            return await Task.FromResult(details);
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
