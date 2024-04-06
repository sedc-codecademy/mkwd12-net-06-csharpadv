using Generics.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Domain
{
    //GeneriDb can work with any type, but that type has to be either BaseEntity 
    //or it has to inherit from BaseEntity
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> items;

        public GenericDb() { 
        
            items = new List<T>();
        }

        public List<T> GetAll()
        {
            return items;
        }

        public void PrintAll()
        {
            foreach(T item in items)
            {
                //we can call GetInfo because T MUST inherit from BaseEntity, which means that whatever type we use for T it will have the GetInfo metjod
                Console.WriteLine(item.GetInfo());
            }
        }

        public T GetById(int id)
        {
            //because T inherits from BaseEntity, T must always have a property Id
            return items.FirstOrDefault(x => x.Id == id);
        }

        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine("The item was added!");
        }

        public void RemoveById(int id)
        {
            T itemToRemove = items.FirstOrDefault(x=> x.Id == id);
            if(itemToRemove == null) {
                Console.WriteLine($"There is no member with id {id} in the db");
                return;
            }
            items.Remove(itemToRemove); //we pass the whole item object that we want to remove from the list
            Console.WriteLine("The item was removed");
        }

    }
}
