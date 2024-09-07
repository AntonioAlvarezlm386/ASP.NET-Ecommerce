using System.Collections.Generic;

namespace DataLayer.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Create(T entity);
        bool Update(T entity, int id);
        bool Delete(int id);
    }
}
