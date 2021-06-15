namespace Oroox.SubSuppliers.Domain.Entities.Job.Details
{
    public enum OperationType
    {
        NOT_SET = 0,
        BENDING = 1,
        CUTTING = 2,
        ELEMENT = 3,
        GRINDING = 4,
        HOLE = 5,
        SURFACE = 6,
        TPI = 7,
        WELDING = 8,
        REDUCTION = 9, 
        MATERIAL = 10,
        SALES = 11,
        MILLING = 12
    }

    public enum ValueGroupType
    {
        PARAMETERS = 0,
        COSTS = 1,
        SUMMARY = 2,
    }

    public enum ValueType
    {
        PERCENTAGE = 0,
        HOURS = 1,
        MINUTES = 2,
        SECONDS = 3,
        CURRENCY = 4,
        PIECES = 5,
        MILIMETERS = 6,
        SQUAREMETERS = 7,
        METERS = 8,
        NONE = 9,
        FOOTS = 10,
        INCHES = 11,
        PRICE_KG = 12,
        KILOGRAMS = 13,
        BOTTOM_LINE = 14,
        COLOUR = 15,
    }

    public class CalculationDetails : Entity
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public decimal? NumericValue { get; set; }
        public OperationType OperationType { get; set; }
        public uint PriorityOrder { get; set; }
        public string Value { get; set; }
        public ValueGroupType ValueGroupType { get; set; }
        public ValueType ValueType { get; set; }
    }
}
