using Api.Framework;
using Application.Interface;
using Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Customer
{

    public class CustomerController : ApiController
    {
        private readonly ICustomerAppService _customerAppService;

        //public CustomerController(IMediator mediator) : base(mediator)
        //{
        //}
        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [AllowAnonymous]
        [HttpGet("customer-management")]
        public async Task<IEnumerable<CustomerViewModel>> Get()
        {
            return await _customerAppService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("customer-management/{id:guid}")]
        public async Task<CustomerViewModel> Get(long id)
        {
            return await _customerAppService.GetById(id);
        }

        [AllowAnonymous]
        [HttpPost("customer-management")]
        public async Task<IActionResult> Post([FromBody] CustomerViewModel customerViewModel)
        {
            return !ModelState.IsValid
                ? CustomResponse(ModelState)
                : CustomResponse(await _customerAppService.Register(customerViewModel));
        }

        [AllowAnonymous]
        [HttpPut("customer-management")]
        public async Task<IActionResult> Put([FromBody] CustomerViewModel customerViewModel)
        {
            return !ModelState.IsValid
                ? CustomResponse(ModelState)
                : CustomResponse(await _customerAppService.Update(customerViewModel));
        }

        [AllowAnonymous]
        [HttpDelete("customer-management")]
        public async Task<IActionResult> Delete(long id)
        {
            return CustomResponse(await _customerAppService.Remove(id));
        }
    }
}
