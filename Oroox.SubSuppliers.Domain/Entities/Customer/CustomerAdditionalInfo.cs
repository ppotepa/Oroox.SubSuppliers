using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class CustomerAdditionalInfo : Entity
    {
        public string SpecialTolerances { get;  set; }
        public double? AverageMinimalSurfaceQualitiesTurning { get;  set; }
        public double? AverageMinimalSurfaceQualitiesMilling { get;  set; }
        public double? AverageAndFastestLeadTimeTurning { get;  set; }
        public double? AverageAndFastestLeadTimeMilling { get;  set; }
        public double? AverageWorkingHoursPerWeek { get;  set; }
        public int? WorkingShiftsPerDay { get;  set; }
        public bool? CanUseStepFiles { get;  set; }
        public string SpecialCharacteristics { get;  set; }
        public Guid CustomerId { get; private set; }
        public virtual Customer Customer { get;  set; }
        
    }
}
