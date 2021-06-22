using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public enum CNCMachineAxesTypeEnum
    {
        THREE_AXIS, 
        THREE_PLUS_ONE_AXIS,
        THREE_PLUS_TWO_AXIS,
        FIVE_AXIS
    }

    public class CNCMachineAxesType : EnumerationEntity<CNCMachineAxesTypeEnum>
    {
        public virtual ICollection<TurningMachine> TurningMachines { get; set; }
        public virtual ICollection<MillingMachine> MillingMachines { get; set; }
    }
}