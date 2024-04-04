using ExtensionMethods.Models;

namespace ExtensionMethods.Helpers
{
    public static class ProductExtensions
    {
        public static void PrintProductInfo(this Product product)
        {
            Console.WriteLine(product.GetInfo());
        }
    }
}
