using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.User.Requests.Customer;
using Oroox.SubSuppliers.Utilities.Abstractions;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.User
{
    /// <summary>
    /// Users Domain Controller
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class CustomersController : ModuleController
    {
        private readonly IApplicationContext context;
        public CustomersController(IMediator mediator, IMapper mapper, IApplicationContext context) : base(mediator, mapper) 
        {
            this.context = context;
        }

        /// <summary>
        /// Creates new Customer.
        /// </summary>
        /// <param name="request">UserDTO</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerModel request) 
            => await Handle(new CreateCustomer(context).Mock());

        /// <summary>
        /// Gets User
        /// </summary>
        /// <returns></returns>
        //[HttpPost]
        //public async Task<IActionResult> Get()
        //{
        //    return new ObjectResult(await this.mapper.Map();
        //}
    }
}
