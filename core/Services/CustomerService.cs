using Core.Interfaces;
using Data.Interfaces;
using Data.Repos;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CustomerService : CrudService<Customer>, ICustomerService
    {
        private readonly ICustomerRepo customerRepo;

        public CustomerService(ICustomerRepo customerRepo) : base(customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        public List<Customer> GetPage(int count, int offset)
        {
            if(count == 0)
            {
                count = 10;
            }
            if (count > 10000)
            {
                count = 10000;
            }
            return customerRepo.GetPage(count, offset);
        }
    }
}
