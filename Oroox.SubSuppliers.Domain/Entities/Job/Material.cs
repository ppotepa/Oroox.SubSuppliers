using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{ 
    public class Material : Entity
    {
        public Material() { }        
        public int ArticleId { get; set; }
        public string DescriptionShortCode { get; set; }
        public string DescriptionLongCode { get; set; }
        public string Shape { get; set; }
        public string BasicType { get; set; }
        public string Unit { get; set; }
        public Guid MaterialTypeId { get; set; }       
        public Guid SurfaceTypeId { get; set; }
        public Guid MarketGroupId { get; set; }
        public bool IsActive { get; set; }
        public Guid LicenseId { get; set; }
        public int? DisplayId { get; set; }
        public virtual MaterialType MaterialType { get; set; }
        public virtual List<MaterialSetting> MaterialSettings { get; set; }
    }

    public enum MaterialTypeEnum
    {
        STEEL,
        STAINLESS_STEEL,
        ALUMINUM
    }
}
