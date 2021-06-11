using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class MillingMachine : CNCMachine
    {
        public double ZMin { get; set; }
        public double ZMax { get; set; }
        public virtual CNCMachineAxesType CNCMachineAxesType { get; set; }
        public Guid CNCMachineAxesTypeId { get; set; }

        public override (string PropertyName, double? Value)[] Dimensions => new[]
        {
            ( propertyName : nameof(this.XMin), value : this.XMin ),
            ( propertyName : nameof(this.XMax), value : this.XMax ),
            ( propertyName : nameof(this.YMin), value : this.YMin ),
            ( propertyName : nameof(this.YMax), value : this.YMax ),
            ( propertyName : nameof(this.ZMin), value : this.ZMin ),
            ( propertyName : nameof(this.ZMax), value : this.ZMax ),
        };
    }
}