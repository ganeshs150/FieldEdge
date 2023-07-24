using Business.Iterface;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerMasterManager _customerMasterManager;
        public CustomerController(ICustomerMasterManager customerMasterManager)
        {
            _customerMasterManager = customerMasterManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            return Ok(await _customerMasterManager.GetCustomers());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            return Ok(await _customerMasterManager.GetCustomerById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(CustomerRequest customerRequest)
        {
            return new JsonResult(await _customerMasterManager.Upsert(customerRequest));
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return new JsonResult(_customerMasterManager.DeleteCustomer(id));
        }
    }
}
