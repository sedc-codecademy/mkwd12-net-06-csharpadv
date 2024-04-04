using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class DogExtension
    {
        public static string GetDogInfo(this Dog d)
        {
            return d.GetInfo() + $"\nFavorite food: {d.FavoriteFood}";
        }
    }
}
