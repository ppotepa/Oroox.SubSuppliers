using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public class TurningMachine : CNCMachine
    {
        public virtual CNCMachineAxesType CNCMachineAxesType { get; set; }
        public Guid CNCMachineAxesTypeId { get; set; }
        public override (string propertyName, double? value)[] Dimensions => new[]
        {
            ( propertyName : nameof(this.XMin), value : this.XMin ),
            ( propertyName : nameof(this.XMax), value : this.XMax ),
            ( propertyName : nameof(this.YMin), value : this.YMin ),
            ( propertyName : nameof(this.YMax), value : this.YMax ),
        };
    }
}