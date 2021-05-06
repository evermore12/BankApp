using Data.EFModels;
using Data.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repos
{
    public class CustomerRepo : CrudRepo<Customer>, ICustomerRepo
    {
        public CustomerRepo(BankAppDataContext db) : base(db)
        {
        }

        public List<Customer> GetPage(int count, int offset)
        {
            return db.Customers.Skip(offset).Take(count).ToList();
        }
    }
}
