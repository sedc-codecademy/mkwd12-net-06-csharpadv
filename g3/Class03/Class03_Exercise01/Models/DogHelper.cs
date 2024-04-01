using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class DogHelper
    {
        public static bool Validate(Dog dog)
        {
            if (dog.Id <= 0) return false;

            if (string.IsNullOrEmpty(dog.Name) || dog.Name.Length < 2) return false;

            return true;

            //return dog.Id > 0 && !string.IsNullOrEmpty(dog.Name) && dog.Name.Length >= 2;
        }
    }
}
