using Business.Iterface;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs;
using System;
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
            try
            {
                return Ok(await _customerMasterManager.GetCustomers());
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            try
            {
                return Ok(await _customerMasterManager.GetCustomerById(id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(CustomerRequest customerRequest)
        {
            try
            {
                return new JsonResult(await _customerMasterManager.Upsert(customerRequest));
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return new JsonResult(_customerMasterManager.DeleteCustomer(id));
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }
    }
}
