using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess.Interfaces
{
    public interface IGenericDb<T> where T : BaseEntity
    {
        int Add(T entity);
        bool Update(T entity);
        bool RemoveById(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
