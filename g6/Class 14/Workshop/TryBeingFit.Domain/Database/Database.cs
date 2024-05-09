using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        private List<T> items {  get; set; }
        public int Id { get; set; }

        public Database()
        {
            items = new List<T>();
            Id = 1;
        }

        public List<T> GetAll()
        {
           return items;
        }

        public T GetById(int id) 
        {
           T item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                throw new NullReferenceException($"Entity with id {id} was not found");
            }
            return item;
        }

        public int Insert(T entity)
        {
            //we set the Id property of the entity and then we increment the value od the Id for the next entity
            entity.Id = Id++;
            items.Add(entity);
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            T item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                throw new NullReferenceException($"Entity with id {id} was not found");
            }
            items.Remove(item);
        }

        public void Update(T entity)
        {
            //first we search if the entity that we want to update exists in our db (our items list)
            T item = items.FirstOrDefault(x => x.Id == entity.Id);
            if (item == null)
            {
                throw new NullReferenceException($"Entity with id {entity.Id} was not found");
            }

            //if it exists update to the object with the new values
            //we have to find the index of the item we want to replace and switch its value
            int indexOfElement = items.IndexOf(item);
            items[indexOfElement] = entity;
        }

    }
}
