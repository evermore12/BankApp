using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICustomerService : ICrudService<Customer>
    {
        public List<Customer> GetPage(int count, int offset);
    }
}
