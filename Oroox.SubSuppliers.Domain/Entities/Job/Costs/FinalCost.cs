using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public class CostPerQuantity : Entity
    {
        public uint Quantity { get; set; }
        public decimal Cost { get; set; }
    }

    public class FinalCost : Entity
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FinalCostType PartialCostType { get; set; }

        [JsonConverter(typeof(OldToNewCostForQuantityModelConverter))]
        public virtual List<CostPerQuantity> CostPerQuantity { get; set; }

        /// <summary>unit cost for date</summary>
        public DateTime Date { get; set; }


        public float Depth { get; set; }    // for cnc [mm]
        public float Volume { get; set; }   // for cnc [m^3] precision up to 0.1 mm^3
        public float Perimeter { get; set; } // [mm]

        public Guid? FinishingId { get; set; }
        public bool IsExcluded { get; set; }
        
    }
    public enum FinalCostType
    {
        NOT_SET = 0,
        RETAIL_PRICE = 23,
        FINAL_UNIT_PRICE_CHF = 24,
        FINAL_UNIT_PRICE_EUR = 25
    }
}
