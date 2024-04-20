using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public class ExampleDatabase<T> : IDatabase<T> where T : BaseEntity
    {
        private List<T> items { get; set; }
        public int Id { get; set; }

        public ExampleDatabase()
        {
            items = new List<T>();
            Id = 1;
        }
        public List<T> GetAll()
        {
            Console.WriteLine("Call from example database");
            return items;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
