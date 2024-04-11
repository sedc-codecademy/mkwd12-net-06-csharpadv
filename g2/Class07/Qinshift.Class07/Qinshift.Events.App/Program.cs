using Qinshift.Events.Domain.Enums;
using Qinshift.Events.Domain.Models;

Console.WriteLine("========== SUPER MARKET ======");
// Create a new market instance
Market market = new Market();
market.Name = "Super Market";
market.ProductType = ProductType.Food;
// Create a new user instance

User user1 = new User { Id=1, Name="Bob Bobsky", Age=28, FavoriteProductType=ProductType.Food };
User user3 = new User { Id=1, Name="Mile Popski", Age=22, FavoriteProductType=ProductType.Other };
User user2 = new User { Id = 2, Name = "Jill Jilliski", Age = 18, FavoriteProductType = ProductType.Electronics };
// Subscribe users for promotions
market.SubscribeForPromotion(user1.ReadPromotion, "bob.bobsky@gmail.com");
// Subscribe users for information
market.SubscribeForInformation(user2.ReadInformation, "jill123@gmail.com");

// Send promotions
market.SendPromotions();


Console.WriteLine("--------------------------");
// Unsubscribe user1
market.UnSubscribeForPromotions(user1.ReadPromotion, "I don't need food promotions anymore.");

market.SubscribeForPromotion(user3.ReadPromotion, "mile.popski@gmail.com");
market.SubscribeForPromotion(user2.ReadPromotion, "jill123@gmail.com");

market.SendPromotions();


Console.WriteLine("==== ZALBI I POPLAKI ====");
market.ReadZalbiPoplaki(); 
Console.ReadLine();