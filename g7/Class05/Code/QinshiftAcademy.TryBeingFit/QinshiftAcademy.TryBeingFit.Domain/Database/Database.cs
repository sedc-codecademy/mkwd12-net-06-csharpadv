

using QinshiftAcademy.TryBeingFit.Domain.Models;

namespace QinshiftAcademy.TryBeingFit.Domain.Database
{
    //first you need to specify the interface, then give details about T
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }

        public Database()
        {
            List<T> items = new List<T>();
        }

        //offer implementations for manipulating entities, inserting, getting, updating, removing
        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
