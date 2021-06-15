using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public class MaterialType : Entity
    {
        public MaterialType() { }
        public Guid LicenseId { get; set; }
        public string TypeCode { get; set; }

        [JsonIgnore]
        public virtual List<Material> Materials { get; set; }
    }
    
}
