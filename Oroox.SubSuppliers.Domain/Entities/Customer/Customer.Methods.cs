using System.Collections.Generic;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public partial class Customer : Entity
    {
        public void AddMachine(Machine machine)
        {
            this.Machines.Add(machine);
            machine.CreatedBy = this.Id;
        }
     
        public void AddMachines(IEnumerable<Machine> machines) => this.Machines.AddRange(machines);
        public void UpdateCustomerAdditionalInfo(CustomerAdditionalInfo info)
        {
            this.CustomerAdditionalInfo = info;
        }
    }
}
