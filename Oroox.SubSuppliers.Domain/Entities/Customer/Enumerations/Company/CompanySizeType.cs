using System.ComponentModel;

namespace Oroox.SubSuppliers.Domain.Entities.Enumerations
{
    public enum CompanySizeType
    {
        [Description("1-10")] LessThan10 = 10,
        [Description("10-25")] LessThan25 = 25,
        [Description("25-50")] LessThan50 = 50,
        [Description("50-100")] LessThan100 = 100,
        [Description(">100")] MoreThan100 = 101,
    }
}