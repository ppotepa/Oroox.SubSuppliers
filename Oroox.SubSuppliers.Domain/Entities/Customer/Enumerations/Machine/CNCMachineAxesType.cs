namespace Oroox.SubSuppliers.Domain.Entities
{
    public enum CNCMachineAxesTypeEnum
    {
        THREE_AXIS, 
        THREE_PLUS_TWO_AXIS,
        FIVE_AXIS
    }

    public class CNCMachineAxesType : EnumerationEntity<CNCMachineAxesTypeEnum> { }
}