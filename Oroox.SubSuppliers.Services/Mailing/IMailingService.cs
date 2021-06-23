using MediatR;
using Oroox.SubSuppliers.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Services.Mailing
{
    public interface IMailingService
    {
        public Task<Unit> SendNewCustomerRegistrationMessage(Customer customer, CancellationToken cancelationToken, string text = null);
        public Task<Unit> SendNewSharedJobNotification(Customer customer, Job job, SharedJob sharedJob, CancellationToken cancelationToken, string text = null);
    }
}