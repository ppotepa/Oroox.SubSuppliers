using MediatR;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oroox.SubSuppliers.Application;

namespace Oroox.SubSuppliers.Tests.Customer
{
    [TestClass]
    public class CustomerTests
    {
        private readonly IHost host;
        private readonly IMediator mediator;

        public CustomerTests()
        {
            this.host = Program.MainForTests(new string[] { });
            this.mediator = this.host.Services.GetService(typeof(IMediator)) as IMediator;
        }

        [TestMethod]
        public void CreateCustomer()
        {
        }
    }
}
