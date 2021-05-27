using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class CustomerAdditionalInfo : Entity
    {
        public void Update(CustomerAdditionalInfo info)
        {
            this.SpecialTolerances = info.SpecialTolerances;
            this.AverageMinimalSurfaceQualitiesTurning = info.AverageMinimalSurfaceQualitiesTurning;
            this.AverageMinimalSurfaceQualitiesMilling = info.AverageMinimalSurfaceQualitiesMilling;
            this.AverageAndFastestLeadTimeTurning = info.AverageAndFastestLeadTimeTurning;
            this.AverageAndFastestLeadTimeMilling = info.AverageAndFastestLeadTimeMilling;
            this.AverageWorkingHoursPerWeek = info.AverageWorkingHoursPerWeek;
            this.WorkingShiftsPerDay = info.WorkingShiftsPerDay;
            this.CanUseStepFiles = info.CanUseStepFiles;
            this.SpecialCharacteristics = info.SpecialCharacteristics;
        }

        public string SpecialTolerances { get; set; }
        public double? AverageMinimalSurfaceQualitiesTurning { get; set; }
        public double? AverageMinimalSurfaceQualitiesMilling { get; set; }
        public double? AverageAndFastestLeadTimeTurning { get; set; }
        public double? AverageAndFastestLeadTimeMilling { get; set; }
        public double? AverageWorkingHoursPerWeek { get; set; }
        public int? WorkingShiftsPerDay { get; set; }
        public bool? CanUseStepFiles { get; set; }
        public string SpecialCharacteristics { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        
    }
}
