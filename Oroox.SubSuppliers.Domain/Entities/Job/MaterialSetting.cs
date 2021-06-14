using System;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public class MaterialSetting : Entity
    {
        public Guid LicenseId { get; set; }
        public virtual Material Material { get; set; }
        public Guid MaterialId { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
    }
   
}
