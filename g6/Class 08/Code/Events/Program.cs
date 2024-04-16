using Events;

User user = new User();
user.FirstName = "Bob";
user.Age = 30;
user.FavouriteProductType = ProductTypeEnum.Fruit;
user.FavouriteStore = StoreEnum.SportVision;

User secondUser = new User();
secondUser.FirstName = "Ana";
secondUser.Age = 25;
secondUser.FavouriteProductType = ProductTypeEnum.Cosmetics;
secondUser.FavouriteStore = StoreEnum.Zara;

Market market = new Market();
market.Name = "Super market";
market.Address = "Address 1";
market.CurrentProductOnPromotion = ProductTypeEnum.Fruit;

Mall mall = new Mall();
mall.Name = "CityMall";
mall.StoreOnSale = StoreEnum.Zara;

//here we pass the method that will be called once the event happens
//the method that we pass as an argument here must follow the PromotionSender delegate signature
market.SubscribeForPromotion(user.ReactOnPromotion);

//market.SubscribeForPromotion(user.SayHello); //ERROR -> SayHello does not follow the PromotionSender delegate signature

market.SubscribeForPromotion(secondUser.ReactOnPromotion);

market.SubscribeForPromotion(user.PrintMarketProduct); //we can subscribe multiple methods as long as they follow the deleagte signature

//in this moment, for the first user ReactOnPromotion and PrintMarketProduct will be called, because they are both subscribed
//for the second user only the ReactOnPromotion method will be called
market.SendPromotion();

//we remove PrintMarketProduct from user from subscribers of the event
market.UnSubscribeForPromotion(user.PrintMarketProduct);

//in this moment, for the first user ReactOnPromotion
//for the second user only the ReactOnPromotion method will be called
market.SendPromotion();

mall.SubscribeForSale(user.ReactOnStoreSale);
mall.SubscribeForSale(secondUser.ReactOnStoreSale);
mall.SendSaleNotification();
mall.UnSubscribeForSale(user.ReactOnStoreSale);
mall.SendSaleNotification();
