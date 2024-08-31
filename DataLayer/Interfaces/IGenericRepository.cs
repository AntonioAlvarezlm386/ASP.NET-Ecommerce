using System.Collections.Generic;

namespace DataLayer.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity, int id);
        void Delete(int id);
    }
}
