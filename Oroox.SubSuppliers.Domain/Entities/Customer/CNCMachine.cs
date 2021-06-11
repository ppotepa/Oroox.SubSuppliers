namespace Oroox.SubSuppliers.Domain.Entities
{
    public enum CNCMachineTypeEnum { MILLING, TURNING }
    public abstract class CNCMachine : Machine
    {
        public double? XMin { get; set; }
        public double? XMax { get; set; }

        public double? YMin { get; set; }
        public double? YMax { get; set; }

        public CNCMachineTypeEnum CNCMachineType
            => this.GetType() == typeof(MillingMachine) ? CNCMachineTypeEnum.MILLING : CNCMachineTypeEnum.TURNING;
    }}