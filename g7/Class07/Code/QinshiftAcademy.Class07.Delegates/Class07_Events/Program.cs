using Class07_Events.Models;

Console.WriteLine("Hello, World!");

var marketVero = new Market
{
    Name = "vero",
    Products = new List<Product>
    {
        new Product
        {
            Name = "Strawberries",
            Category = Class07_Events.Enums.CategoryEnum.Fruits,
            Price = 150
        },
        new Product
        {
            Name = "Pork",
            Category = Class07_Events.Enums.CategoryEnum.Meat,
            Price = 450
        },
        new Product
        {
            Name = "Cheese",
            Category = Class07_Events.Enums.CategoryEnum.Milk,
            Price = 500
        },
    }
};

var kamMarket = new Market
{
    Name = "KamMarket",
    Products = new List<Product>
    {
        new Product
        {
            Name = "Strawberries",
            Category = Class07_Events.Enums.CategoryEnum.Fruits,
            Price = 100
        },
        new Product
        {
            Name = "Tomato",
            Category = Class07_Events.Enums.CategoryEnum.Vegetables,
            Price = 90
        },
        new Product
        {
            Name = "Cheese",
            Category = Class07_Events.Enums.CategoryEnum.Milk,
            Price = 400
        },
    }
};

var user1 = new User
{
    FirstName = "Aleksandar",
    LastName = "Milovski",
    FavoriteCategory = Class07_Events.Enums.CategoryEnum.All
};

var user2 = new User
{
    FirstName = "Todor",
    LastName = "Pelivanov",
    FavoriteCategory = Class07_Events.Enums.CategoryEnum.Meat
};

marketVero.Subscribe(user1.NewPromotion);
marketVero.CreatePromotion();
marketVero.CreatePromotion();

marketVero.Subscribe(user2.NewPromotion);
marketVero.CreatePromotion();

marketVero.Unsubscribe(user2.NewPromotion);
marketVero.CreatePromotion();


