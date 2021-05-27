namespace Oroox.SubSuppliers.Domain.Entities
{
    public partial class Customer : Entity
    {
        public void AddMillingMachine(MillingMachine machine)
        {
            this.MillingMachines.Add(machine);
        }

        public void AddTurningMachine(TurningMachine machine)
        {
            this.TurningMachines.Add(machine);
        }

        public void UpdateCustomerAdditionalInfo(CustomerAdditionalInfo info)
        {
            this.CustomerAdditionalInfo = info;
        }
    }
}
