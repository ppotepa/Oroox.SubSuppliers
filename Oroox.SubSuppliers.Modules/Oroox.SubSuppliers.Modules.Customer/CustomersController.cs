using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Customers.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests;
using Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests.GetCustomerById;
using Oroox.SubSuppliers.Modules.Customers.Requests.GetCustomerById.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo;
using Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.Model;
using Oroox.SubSuppliers.Utilities.Abstractions;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Modules.Customers
{
    /// <summary>
    /// Users Domain Controller
    /// </summary>    
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
            => await Handle(this.mapper.Map<CreateCustomerModel, CreateCustomerRequest>(request));

        /// <summary>
        /// Gets User
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Activate([FromQuery] ActivateCustomerModel request)
            => await Handle(this.mapper.Map<ActivateCustomerModel, ActivateCustomerRequest>(request));

        [HttpPost]
        public async Task<IActionResult> GetCustomerById(GetCustomerByIdModel request)
            => await Handle(this.mapper.Map<GetCustomerByIdModel, GetCustomerByIdRequest>(request));

        [HttpPost]
        public async Task<IActionResult> UpdateCustomerInfo(UdateCustomerAdditionalInfoModel request)
            => await Handle(this.mapper.Map<UdateCustomerAdditionalInfoModel, UpdateCustomerAdditionalInfoRequest>(request));

        [HttpPost]
        public async Task<IActionResult> AddTurningMachineRequest(ActivateCustomerModel request)
            => await Handle(this.mapper.Map<ActivateCustomerModel, ActivateCustomerRequest>(request));

        //[HttpPost]
        //public async Task<IActionResult> AddTurningMachine(ActivateCustomerModel request)
        //    => await Handle(this.mapper.Map<ActivateCustomerModel, ActivateCustomerRequest>(request));

    }
}
