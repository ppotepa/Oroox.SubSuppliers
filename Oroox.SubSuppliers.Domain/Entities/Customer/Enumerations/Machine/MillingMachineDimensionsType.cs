namespace Oroox.SubSuppliers.Domain.Entities
{
    public enum MillingMachineDimensionsTypeEnum
    {
        THREE_AXIS, 
        THREE_PLUS_TWO_AXIS,
        FIVE_AXIS
    }

    public class MillingMachineDimensionsType : EnumerationEntity<MillingMachineDimensionsTypeEnum>
    {
    }
}