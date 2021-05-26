using System;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.DTO
{
    public class CustomerAdditionalInfoDTO
    {
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
    }
}