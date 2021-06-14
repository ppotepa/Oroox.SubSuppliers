using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities.Job
{
    public class Material : Entity
    {
        public Material() { }        
        public int ArticleId { get; set; }
        public string DescriptionShortCode { get; set; }
        public string DescriptionLongCode { get; set; }
        public string Shape { get; set; }               // This should be Bar/Plate  etc.
        public string BasicType { get; set; }
        public string Unit { get; set; }
        public Guid MaterialTypeId { get; set; }        // This should be Steel/Aluminum etc.  Bar/Plate should be in Shape
        public Guid SurfaceTypeId { get; set; }
        public Guid MarketGroupId { get; set; }
        public bool IsActive { get; set; }
        public Guid LicenseId { get; set; }
        public int? DisplayId { get; set; }
        public MaterialType MaterialType { get; set; }
        public List<MaterialSetting> MaterialSettings { get; set; }
    }
    public interface IMaterialFK
    {
        Guid MaterialId { get; set; }
        Material Material { get; set; }
    }

    public enum MaterialTypeEnum
    {
        STEEL,
        STAINLESS_STEEL,
        ALUMINUM
    }
}
