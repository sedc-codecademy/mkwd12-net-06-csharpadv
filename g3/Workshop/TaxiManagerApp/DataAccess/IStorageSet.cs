using Models;

namespace DataAccess
{
    public interface IStorageSet<T> where T : BaseEntity
    {
        //CRUD - Create, Read, Update, Delete
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
