using TaxiManager9000.DataAccess;
using TaxiManager9000.DataAccess.Interfaces;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        private IGenericDb<T> _db;

        public ServiceBase()
        {
            //_db = new GenericDb<T>();
            _db = new FileSystemDb<T>();
        }

        public List<T> GetAll()
        {
            return _db.GetAll();
        }

        public T GetById(int id)
        {
            return _db.GetById(id);
        }

        public List<T> GetFiltered(Func<T, bool> predicate)
        {
            return _db.FilterBy(predicate);
        }

        public void Insert(T entity)
        {
            _db.Add(entity);
        }

        public bool Update(T entity)
        {
            _db.Update(entity);
            return true;
        }

        public void Remove(int id)
        {
            _db.RemoveById(id);
        }

        public void Seed(List<T> entities)
        {
            if (!SeedCompleted())
            {
                entities.ForEach(entity => _db.Add(entity));
            }
        }

        private bool SeedCompleted()
        {
            List<T> entitiesDb = GetAll();
            if (entitiesDb == null)
            {
                return false;
            }
            return entitiesDb.Any();
        }

    }
}
