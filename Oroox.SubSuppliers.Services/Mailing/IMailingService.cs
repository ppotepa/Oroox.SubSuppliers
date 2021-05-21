using Oroox.SubSuppliers.Domain.Entities;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public interface IMailingService
    {
        public bool SendCustomerRegistrationEmail(Customer customer);
       
    }
}