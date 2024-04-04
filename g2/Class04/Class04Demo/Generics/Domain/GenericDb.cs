using Generics.Domain.Interfaces;
using Generics.Domain.Models.BaseModel;

namespace Generics.Domain
{
    // "where T : BaseEntity" ===> only classes derived from BaseEntity are allowed to use GenericDb<T>
    public class GenericDb<T> : IGenericDb<T> where T : BaseEntity
    {
        private List<T> Db;
        public GenericDb()
        {
            Db = new List<T>();
        }

        public T GetById(int id)
        {
            return Db.FirstOrDefault(t => t.Id == id);
        }

        public T GetByIndex(int index)
        {
            return Db[index];
        }

        public void Insert(T item)
        {
            Db.Add(item);
            Console.WriteLine($"Item was added in the {item.GetType().Name} Db!");
        }

        public void PrintAll()
        {
            foreach(T item in Db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void RemoveById(int id)
        {
            T item = Db.SingleOrDefault(t => t.Id == id);
            if (item == null)
            {
                Console.WriteLine($"Item was not found in the {item.GetType().Name} Db!");
                return;
            }
            Db.Remove(item);
            Console.WriteLine($"Item was removed from the {item.GetType().Name} Db!");
        }

    }
}
