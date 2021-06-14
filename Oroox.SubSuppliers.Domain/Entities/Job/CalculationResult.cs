﻿using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public class CalculationResult : Entity
    {
        public Guid Id { get; set; }
        public Guid QuoteId { get; set; } // 1-1 relation with quote
        public DateTime DateOfCalculation { get; set; }

        /// <summary>
        /// PartialCosts - independent on the day of delivery.
        /// PartialCostType is unique in this list.
        /// </summary>
        public List<PartialCost> PartialCosts { get; set; } = new List<PartialCost>();

        /// <summary>
        /// FinalCosts - for each of the dates (FinalCostType is not unique).
        /// Contains codes: RETAIL_PRICE, FINAL_UNIT_PRICE_CHF, FINAL_UNIT_PRICE_EUR
        /// </summary>
        public List<FinalCost> FinalCosts { get; set; } = new List<FinalCost>();

        /// <summary>Cached details of this calculation. Displayed in admin panel.</summary>
        /// moved to separate object with relation to quote.
        //public CalcDetailsForQuote CalcDetailsForQuote { get; set; } = new CalcDetailsForQuote();

        public decimal FinalPriceForPrototype { get; set; }
        public decimal FinalBestUnitPrice { get; set; }
    }
}
