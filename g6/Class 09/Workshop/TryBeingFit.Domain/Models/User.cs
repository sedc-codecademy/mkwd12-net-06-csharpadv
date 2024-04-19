using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Enums;

namespace TryBeingFit.Domain.Models
{
    //we don't want to be able to create an user that is just an user so we need to mark the class abstract
    public abstract class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserRoleEnum UserRole { get; set; }
    }
}
