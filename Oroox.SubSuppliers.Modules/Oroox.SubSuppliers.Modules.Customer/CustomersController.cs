using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Modules.User.Requests.CreateCustomer;
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
        public CustomersController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }

        /// <summary>
        /// Creates new Customer.
        /// </summary>
        /// <param name="request">UserDTO</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerModel request) 
            => await Handle(CreateCustomer.NewCreateCustomerRequest);

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
