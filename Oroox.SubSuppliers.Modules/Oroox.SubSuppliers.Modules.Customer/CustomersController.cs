using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Modules.Customers.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer;
using Oroox.SubSuppliers.Modules.Customers.Requests.ActivateCustomer.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerMillingMachine.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines;
using Oroox.SubSuppliers.Modules.Customers.Requests.AddCustomerTurningMachines.Model;
using Oroox.SubSuppliers.Modules.Customers.Requests.CreateCustomer;
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
            => await Handle(request: this.mapper.Map<CreateCustomerModel, CreateCustomerRequest>(request));

        /// <summary>
        /// Gets User
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Activate([FromQuery] ActivateCustomerModel request)
            => await Handle(request: this.mapper.Map<ActivateCustomerModel, ActivateCustomerRequest>(request));

        [HttpGet]
        public async Task<IActionResult> GetCustomerById(GetCustomerByIdResponseModel request)
            => await Handle(request: this.mapper.Map<GetCustomerByIdResponseModel, GetCustomerByIdRequest>(request));

        [HttpPatch]
        public async Task<IActionResult> UpdateCustomerInfo(UdateCustomerAdditionalInfoModel request)
            => await Handle(request: this.mapper.Map<UdateCustomerAdditionalInfoModel, UpdateCustomerAdditionalInfoRequest>(request));

        [HttpPut]
        public async Task<IActionResult> AddCustomerTurningMachine(AddCustomerTurningMachinesModel request)
            => await Handle(request: this.mapper.Map<AddCustomerTurningMachinesModel, AddCustomerTurningMachinesRequest>(request));

        [HttpPut]
        public async Task<IActionResult> AddCustomerMillingMachine(AddCustomerMillingMachineModel request) 
            => await Handle(request: this.mapper.Map<AddCustomerMillingMachineModel, AddCustomerMillingMachineRequest>(request));
    }
}
