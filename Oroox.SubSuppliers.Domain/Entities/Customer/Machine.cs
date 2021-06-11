using System;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public abstract class Machine : Entity
    {
        public virtual Customer Customer { get; set; }
        public string MachineNumber { get; set; }
        public string Name { get; set; }
        public Guid CustomerId { get; set; }

        public string MachineTypeName 
        {
            get
            {
                if (this._machineTypeName is null)
                    _machineTypeName = this.GetType().Name;
                return _machineTypeName;
            }
            set => this._machineTypeName = value;
        }
        private string _machineTypeName;
    }
}