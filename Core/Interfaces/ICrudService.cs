using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICrudService<T>
    {
        T Create(T entity);
        T Get(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
