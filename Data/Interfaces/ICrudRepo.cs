using System;
namespace Data.Interfaces
{
    public interface ICrudRepo<T>
    {
        T Create(T entity);
        T Get(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
