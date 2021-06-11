using System;

namespace Oroox.SubSuppliers.Modules.Customers.CreateCustomer.DTO
{
    public class CreateCustomerDTO 
    {  
        public string CompanyName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string EmailAddress { get; set; }
        public string WebSite { get; set; }
        public Guid CompanySizeTypeId { get; set; }        
    }
}
