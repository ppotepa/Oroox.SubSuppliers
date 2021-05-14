using Oroox.SubSuppliers.Utilities.Abstractions;

namespace Oroox.SubSuppliers.Experimentals.Enumerations
{
    public class OrderType : Enumeration
    {
        public static readonly OrderType Express = new OrderType(1, "Express");
        public static readonly OrderType Regular = new OrderType(2, "Regular");

        public OrderType(int value, string displayName) : base(value, displayName) { }        
    }
}
