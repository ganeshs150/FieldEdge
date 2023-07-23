using Business.Iterface;
using Business.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
