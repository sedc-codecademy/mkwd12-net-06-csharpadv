using Class07_Events.Enums;

namespace Class07_Events.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName}  {LastName}";
        public CategoryEnum FavoriteCategory { get; set; }

        public void NewPromotion(Product product, int newPrice)
        {
            Console.WriteLine($"{FullName} has received promotion about {product.Name}");

            if (FavoriteCategory == product.Category)
            {
                Console.WriteLine($"{FullName}: I am happy!");
            }

            if(FavoriteCategory == CategoryEnum.All)
            {
                Console.WriteLine($"{FullName}: I am always happy!");
            }
        }
    }
}
