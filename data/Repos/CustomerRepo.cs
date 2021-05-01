using System;
using Data.Interfaces;
using Data.EFModels;
using Domain.Models;
namespace Data.Repos
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly BankAppDataContext db;

        public CustomerRepo(BankAppDataContext db)
        {
            this.db = db;
        }
        public int Create(Customer entity)
        {
            db.Customers.Add(entity);
            db.SaveChanges();
            return entity.CustomerId;
        }

        public void Delete(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Remove(customer);
            db.SaveChanges();
        }

        public Customer Get(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.SaveChanges();
            return customer;
        }

        public void Update(Customer entity)
        {
            Customer oldCustomer = db.Customers.Find(entity.CustomerId);
            db.Entry(oldCustomer).OriginalValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}
