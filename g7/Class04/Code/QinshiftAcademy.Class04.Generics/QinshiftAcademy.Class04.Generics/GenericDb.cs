

using QinshiftAcademy.Class04.Generics.Models;

namespace QinshiftAcademy.Class04.Generics
{
    //We want this class to contain methods for manipulating the data that we keep for our entities
    //we want to store records for entities in the class

    //we can replace T with any type that is BaseEntity or inherits from BaseEntity
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> _items;

        public GenericDb()
        {
            _items = new List<T>();
        }

        public void PrintAllItems()
        {
            foreach (T item in _items)
            {
                //T inherits from BaseEntity, it has to inherit from BaseEntity, which means it has GetInfo method
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Add(T item)
        {
            _items.Add(item);
            Console.WriteLine("Item was added");
        }

        public List<T> GetAll()
        {
            return _items;
        }

        public T GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveById(int id)
        {
            //first search if the records exists
            T itemForRemoval = _items.FirstOrDefault(x => x.Id == id);
            if(itemForRemoval == null)
            {
                Console.WriteLine($"There is no item with id {id}.");
                return;
            }

            //then remove
            _items.Remove(itemForRemoval);
            Console.WriteLine("Item was removed");
        }
    }
}
