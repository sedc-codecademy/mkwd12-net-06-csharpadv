

using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public interface IDatabase<T> where T : BaseEntity
    {
        List<T> GetAll();

        T GetById (int id);

        int Insert(T entity); //Add

        void Update(T entity);

        void RemoveById(int id);
    }
}
