namespace Oroox.SubSuppliers.Domain.Entities
{
    public partial class Customer : Entity
    {
        public void AddMachine(Machine machine)
        {
            this.Machines.Add(machine);
        }

        public void UpdateCustomerAdditionalInfo(CustomerAdditionalInfo info)
        {
            this.CustomerAdditionalInfo = info;
        }
    }
}
