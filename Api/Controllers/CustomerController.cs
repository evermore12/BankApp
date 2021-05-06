using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;
using Core.Services;
using Domain.Models;
using Data.Repos;

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
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            return Ok(customerService.Create(customer));
        }
        [HttpGet("{id}")]
        public IActionResult Remove(int id)
        {
            customerService.Delete(id);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get(int count, int offset)
        {
            return Ok(customerService.GetPage(count, offset));
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(customerService.Get(id));
        }
    }
}
