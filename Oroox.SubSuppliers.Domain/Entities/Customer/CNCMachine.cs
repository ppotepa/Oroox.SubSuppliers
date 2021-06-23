using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public enum CNCMachineTypeEnum { MILLING, TURNING, MILLING_AND_TURNING }
    public abstract class CNCMachine : Machine
    {
        public double? XMin { get; set; }
        public double? XMax { get; set; }

        public double? YMin { get; set; }
        public double? YMax { get; set; }

        //public CNCMachineTypeEnum CNCMachineType
        //{
        //    get
        //    {
        //        Type currentType = IsProxyType ? this.GetType().BaseType : this.GetType();   
        //        if (currentType == typeof(MillingMachine)) return CNCMachineTypeEnum.MILLING;
        //        if (currentType == typeof(TurningMachine)) return CNCMachineTypeEnum.TURNING;
        //        if (currentType == typeof(MillingMachine)) return CNCMachineTypeEnum.MILLING;
        //        throw new InvalidOperationException("Invalid machine type specified.");

        //    }
        //}


        public virtual (string PropertyName, double? Value)[] Dimensions
            => throw new NotImplementedException("");
    }
}