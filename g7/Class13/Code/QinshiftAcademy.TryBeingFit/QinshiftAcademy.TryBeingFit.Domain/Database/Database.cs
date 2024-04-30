

using QinshiftAcademy.TryBeingFit.Domain.Models;

namespace QinshiftAcademy.TryBeingFit.Domain.Database
{
    //first you need to specify the interface, then give details about T
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }
        public int Id { get; set; }

        public Database()
        {
            Items = new List<T>();
            Id = 1;
        }

        //offer implementations for manipulating entities, inserting, getting, updating, removing
        public int Insert(T entity)
        {
            entity.Id = Id++; //for example, entity.Id will get value 1, after that the value of Id will be incremented to 2
            Items.Add(entity);
            return entity.Id;
        }

        public List<T> GetAll()
        {
            return Items;
        }

        public T GetById(int id)
        {
            T dbItem = Items.FirstOrDefault(x => x.Id == id);
            return dbItem;
        }

        public void Update(T entity)
        {
            //first we need to find by id the memeber of the collection that we wnat to update
            //entity param should have a valid, existing value for the id
            T dbItem = Items.FirstOrDefault(x => x.Id == entity.Id);
            if(dbItem == null)
            {
                throw new Exception($"Item with id {entity.Id} was not found.");
            }

            //we have to find the index of the item we want to replace and switch its value
            int index = Items.IndexOf(dbItem);
            Items[index] = entity;
        }

        public void DeleteById(int id)
        {
            T dbItem = Items.FirstOrDefault(x => x.Id == id);
            if (dbItem == null)
            {
                throw new Exception($"Item with id {id} was not found.");
            }

            Items.Remove(dbItem);
        }
    }
}
