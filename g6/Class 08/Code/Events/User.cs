
namespace Events
{
    public class User
    {

        public string FirstName { get; set; }   
        public int Age { get; set; }

        public ProductTypeEnum FavouriteProductType {  get; set; }

        public StoreEnum FavouriteStore {  get; set; }

        //subscription method, must follow the delagte signature
        //it will be executed when certain product is on promotion
        public void ReactOnPromotion(ProductTypeEnum productType)
        {
            if(productType == FavouriteProductType)
            {
                Console.WriteLine($"{FirstName}: My favourite product is on promotion");
            }
            else
            {
                Console.WriteLine($"{FirstName} must wait. {FavouriteProductType.ToString()} is not on promotion");
            }
        }


        public void PrintMarketProduct(ProductTypeEnum productType)
        {
            Console.WriteLine($"The product that is on promotion at our market is {productType}");
        }

        //we need a method that follows the StoreSale delegate (returns string and has one param StoreEnum)
        public string ReactOnStoreSale(StoreEnum store)
        {
            if (store == FavouriteStore)
            {
                return $"{FirstName}: My favourite store is on sale";
            }
            else
            {
                return $"{FirstName} must wait. {FavouriteStore.ToString()} is not on sale";
            }
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
