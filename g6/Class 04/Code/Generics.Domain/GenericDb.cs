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
    }
}
