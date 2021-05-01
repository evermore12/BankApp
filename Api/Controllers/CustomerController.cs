using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;
using Core.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        [HttpGet("{id}")]
        public IActionResult RemoveCustomer(int id)
        {
            customerService.RemoveCustomer(id);

            return Ok();
        }
    }
}
