using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.Implementations
{
    public class SecondUserService<T> : IUserService<T> where T : User
    {
        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public T Register(T newUser)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
