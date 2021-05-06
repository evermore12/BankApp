using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTypeController : ControllerBase
    {
        private readonly ICrudService<AccountType> accountTypeService;

        public AccountTypeController(ICrudService<AccountType> accountTypeService)
        {
            this.accountTypeService = accountTypeService;
        }
        [HttpPost]
        public IActionResult Create(AccountType accountType)
        {
            accountTypeService.Create(accountType);
            return Ok();
        }
    }
}
