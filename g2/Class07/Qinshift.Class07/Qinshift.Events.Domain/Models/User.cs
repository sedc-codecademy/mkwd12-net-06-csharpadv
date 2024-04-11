using Qinshift.Events.Domain.Enums;

namespace Qinshift.Events.Domain.Models
{
    // This class is a subscriber class
    // It can subscribe to publishers and can get info every time the publisher decides to send some info to all subscribers
    // This subscriber class is representing a user that has the ability to subscribe for promotions
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ProductType FavoriteProductType { get; set; }
        public User()
        {

        }

        // A method that can read a promotion and get excited if that is the favorite type of this person
        public void ReadPromotion(ProductType productType)
        {
            Console.WriteLine($"Mr/Ms: {Name}, The product {productType} is on sale.");
            if(productType == FavoriteProductType)
            {
                Console.WriteLine("MY FAVORITE PRODUCT!");
            }
        }
        public void ReadInformation(string info)
        {
            Console.WriteLine($"Mr/Ms: {Name}, {info}");
        }
    }
}
