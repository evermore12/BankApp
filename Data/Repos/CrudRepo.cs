using Data.EFModels;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos
{
    public class CrudRepo<T> : ICrudRepo<T>
    {
        protected readonly BankAppDataContext db;

        public CrudRepo(BankAppDataContext db)
        {
            this.db = db;
        }
        public T Create(T entity)
        {
            db.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public T Get(int id)
        {
            return (T)db.Find(typeof(T), id);
        }

        public void Delete(int id)
        {
            db.Remove(db.Find(typeof(T), id));
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Update(entity).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}
