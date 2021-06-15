using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public enum QuoteStatusCode
    {
        UNKNOWN = 0,
        QUOTE_ERROR = 1,
        QUOTE_UNCALCULABLE = 2,
        QUOTE_NEVER_SAVED_AFTER_UPLOAD = 3,
        QUOTE_CONFIG_NOT_FINISHED = 4,
        QUOTE_CONFIG_INVALID = 5,
        QUOTE_READY_FOR_ORDER = 6,
        QUOTE_ADDED_TO_CART = 7,
        QUOTE_ORDERED = 8,
        DXF_UPLOADED = 9,
        DXF_CONFIGURED_BY_USER = 10,
        DXF_CONVERSION_FAILED = 11,
    }

    public class Quote : Entity
    {   
        public Guid CadFileId { get; set; }
        public virtual List<MilledPart> MilledParts { get; set; } = new List<MilledPart>();
        public float Width { get; set; } // [m] precision up to 0.01 mm
        public float Height { get; set; } // [m] precision up to 0.01 mm
        public float Depth { get; set; } //[m]  precision up to 0.01 mm                                   

        public QuoteStatusCode StatusCode { get; set; }

        public uint? ChosenQuantity { get; set; }
        public DateTime? ChosenDeliveryDate { get; set; }

        /// <summary>Latest calculation result. Ignored in OxContext</summary>
        public virtual CalculationResult CalculationResult { get; set; }
        public virtual Guid CalculationResultId { get; set; }
    }
}
