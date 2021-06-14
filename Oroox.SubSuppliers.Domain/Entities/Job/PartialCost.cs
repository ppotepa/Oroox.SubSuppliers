using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public interface IPartialCost<T> where T : Enum
    {
        Guid Id { get; set; }
        Dictionary<uint, decimal> CostPerQuantity { get; set; }

        /// <summary>PartialCostType or FinalCostType</summary>
        T PartialCostType { get; set; }
    }

    public class PartialCost : IPartialCost<PartialCostType>
    {
        public PartialCost()
        {
            CostPerQuantity = new Dictionary<uint, decimal>();
        }

        public Guid Id { get; set; }
        public Guid CalculationResultId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PartialCostType PartialCostType { get; set; }

        /// <summary>unit cost for quantity</summary>
        public Dictionary<uint, decimal> CostPerQuantity { get; set; }
    }

    public enum PartialCostType
    {
        NOT_SET = 0,

        MATERIAL_HK,
        MATERIAL_FIX,
        MATERIAL_VAR,
        MATERIAL_SK1,

        THIRD_PARTY_ITEMS_HK,
        THIRD_PARTY_ITEMS_FIX,
        THIRD_PARTY_ITEMS_VAR,
        THIRD_PARTY_ITEMS_SK1,

        SURFACE_FINISHING_HK,
        SURFACE_FINISHING_FIX,
        SURFACE_FINISHING_VAR,
        SURFACE_FINISHING_SK1,

        MANUFACTURING_HK,
        MANUFACTURING_FIX,
        MANUFACTURING_VAR,
        MANUFACTURING_SK1,

        TOTAL_SK1,
        RISK,
        PROFIT,
    }
}
