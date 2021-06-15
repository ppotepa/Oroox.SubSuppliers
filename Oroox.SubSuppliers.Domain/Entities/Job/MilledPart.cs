using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public class MilledPart : Entity
    {
        public MilledPart()
        {
            Holes = new List<Hole>();
        }

        public Guid QuoteId { get; set; }
        public virtual List<Hole> Holes { get; set; } = new List<Hole>();
        public float Width { get; set; }// precision up to 0.01 mm  
        public float Height { get; set; }// precision up to 0.01 mm
        public float Depth { get; set; }// precision up to 0.01 mm 
        public float RealVolume { get; set; } // [m^3] precision up to 0.1 mm^3

        public MilledPartType MilledPartType { get; set; }

        public bool IsCalculable { get; set; }

        public string ProductName { get; set; }            // exported from the STEP file
        public string ProductDescription { get; set; }     // exported from the STEP file
        public string InstanceName { get; set; }           // exported from the STEP file
        public string BrepName { get; set; }               // exported from the STEP file


        // config
        public Guid? MaterialId { get; set; }

    }

    public enum MilledPartType
    {
        NOT_SET = 0,
        SIMPLE = 1,             // one solid
        FEATURE_COMPOUND = 2,   // multiple solids
    }

}
