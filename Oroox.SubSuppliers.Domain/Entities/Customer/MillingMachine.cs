namespace Oroox.SubSuppliers.Domain.Entities
{
    public class MillingMachine : CNCMachine
    {
        public double ZMin { get; set; }
        public double ZMax { get; set; }
        public CNCMachineAxesType CNCMachineAxesType { get; set; }
    };

}