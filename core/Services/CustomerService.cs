using System;
using Core.Interfaces;
using Data.Repos;
using Domain.Models;
using Data.Interfaces;
namespace Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo customerRepo;

        public CustomerService(ICustomerRepo customerRepo, IDispositionRepo dispositionRepo)
        {
            this.customerRepo = customerRepo;
        }

        public void RemoveCustomer(int id)
        {
            customerRepo.Delete(id);
            throw new NotImplementedException();
        }
        public int CreateCustomer(Customer customer)
        {
            dis
        }
    }
}
