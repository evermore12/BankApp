using System;
namespace Data.Interfaces
{
    public interface ICrud<T>
    {
        int Create(T entity);
        T Get(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
