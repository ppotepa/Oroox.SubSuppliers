using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class Hole : Entity
    {
        public Guid PartId { get; set; }        

        /// <summary>If HoleShape = ROUND</summary>
        public float? Diameter { get; set; } // mm
        /// <summary>If HoleShape = ROUND</summary>
        public bool CountersinkDetected { get; set; }
        /// <summary>If HoleShape = ROUND</summary>
        public SinkingMethodType? SinkingMethodType { get; set; }
        /// <summary>If HoleShape = SQUARE/RECTANGULAR/SLOTTED</summary>
        public float? LengthA { get; set; }  // mm
        /// <summary>If HoleShape = RECTANGULAR/SLOTTED</summary>
        public float? LengthB { get; set; }  // mm

        public float Depth { get; set; }    // for cnc [mm]
        public float Volume { get; set; }   // for cnc [m^3] precision up to 0.1 mm^3
        public float Perimeter { get; set; } // [mm]

        public Guid? FinishingId { get; set; }
        public bool IsExcluded { get; set; }
        public Hole() { }
    }
    public enum SinkingMethodType
    {
        NOT_SET = 0,
        TYPE_1 = 1,
        TYPE_2 = 2,
        TYPE_3 = 3
    };

    public enum HoleShape
    {
        NOT_SET = 0,
        ROUND = 1,
        SQUARE = 2,
        RECTANGULAR = 3,
        SLOTTED = 4 // = Langloch
    }
}
