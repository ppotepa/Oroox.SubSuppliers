using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests;
using Oroox.SubSuppliers.Modules.Customers.Requests.GetCustomerById;
using Oroox.SubSuppliers.Modules.Customers.Requests.GetCustomerById.Model;
using Oroox.SubSuppliers.Utilities.Abstractions;
using System;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers
{
    /// <summary>
    /// Users Domain Controller
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class CustomersController : ModuleController
    {
        public CustomersController(IMediator mediator, IMapper mapper, IApplicationContext context) 
            : base(mediator, mapper, context) { }
       

        /// <summary>
        /// Creates new Customer.
        /// </summary>
        /// <param name="request">UserDTO</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerModel request) 
            => await Handle(new CreateCustomerRequest(context).Mock());

        /// <summary>
        /// Gets User
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetCustomerById(GetCustomerByIdModel request)
            =>  await Handle
            (
                new GetCustomerByIdRequest
                {
                    Customer = new Customer 
                    {
                        Id = Guid.Parse("BC0AE377-9322-4D1F-0C92-08D91C5D457C"),
                    } 
                }
            );
    }
}
