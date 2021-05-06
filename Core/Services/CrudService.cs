using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Repos;
using Data.Interfaces;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CrudService<T> : ICrudService<T>
    {
        protected readonly ICrudRepo<T> crudRepo;

        public CrudService(ICrudRepo<T> crudRepo)
        {
            this.crudRepo = crudRepo;
        }
        public T Create(T entity)
        {
            return crudRepo.Create(entity);
        }

        public void Delete(int id)
        {
            crudRepo.Delete(id);
        }

        public T Get(int id)
        {
            return crudRepo.Get(id);
        }

        public void Update(T entity)
        {
            crudRepo.Update(entity);
        }
    }
}
