using System.Collections.Generic;

namespace Oroox.SubSuppliers.Modules.Customers.DTO
{
    public class CreateCustomerDTO 
    {
        public List<MillingMachineDTO> MillingMachines { get; set; }        
        public List<TurningMachineDTO> TurningMachines { get; set; }        
        public string CompanyName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string EmailAddress { get; set; }
    }
}
