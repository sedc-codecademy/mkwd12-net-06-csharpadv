using Models;
using System.Text;

namespace Class07_EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var marketVero = new Market
            {
                Name = "Vero",
                Products = new List<Product>
                {
                    new Product
                    {
                        Name = "Jagodi",
                        Category = CategoryEnum.Fruits,
                        Price = 150
                    },
                    new Product
                    {
                        Name = "Svinsko meso",
                        Category = CategoryEnum.Meat,
                        Price = 450
                    },
                    new Product
                    {
                        Name = "Kashkaval",
                        Category = CategoryEnum.Milk,
                        Price = 500
                    }
                }
            };

            var marketKam = new Market
            {
                Name = "Kam",
                Products = new List<Product>
                {
                    new Product
                    {
                        Name = "Jagodi",
                        Category = CategoryEnum.Fruits,
                        Price = 100
                    },
                    new Product
                    {
                        Name = "Domat",
                        Category = CategoryEnum.Vegetables,
                        Price = 90
                    },
                    new Product
                    {
                        Name = "Sirenje",
                        Category = CategoryEnum.Milk,
                        Price = 400
                    }
                }
            };

            var user1 = new User
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                FavoriteCategory = CategoryEnum.All
            };

            var user2 = new User
            {
                FirstName = "Slave",
                LastName = "Ivanovski",
                FavoriteCategory = CategoryEnum.Meat
            };

            marketVero.Subscribe(user1.NewPromotion);
            marketVero.CreatePromotion();

            marketVero.Subscribe(user2.NewPromotion);
            marketVero.CreatePromotion();

            var site = new WebAggregator
            {
                Name = "Letok",
                Url = "letok.mk"
            };

            marketKam.Subscribe(site.NewProductPromotion);
            marketVero.Subscribe(site.NewProductPromotion);

            marketVero.CreatePromotion();
            marketKam.CreatePromotion();
        }
    }
}
