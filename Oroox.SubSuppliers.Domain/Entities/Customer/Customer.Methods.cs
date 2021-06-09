using Oroox.SubSuppliers.Domain.Context;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public partial class Customer : Entity
    {
        public void AddMachine(TurningMachine machine, IApplicationContext ctx)
        {
            this.Machines.Add(machine);
        }

        public void UpdateCustomerAdditionalInfo(CustomerAdditionalInfo info)
        {
            this.CustomerAdditionalInfo = info;
        }
    }
}
