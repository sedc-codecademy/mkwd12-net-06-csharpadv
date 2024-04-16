namespace Models
{
    public class WebAggregator
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public void NewProductPromotion(Product p, int price)
        {
            Console.WriteLine($"The product {p.Name}, has new price {price:C}. This will be presented on our website: {Url}");
        }
    }
}
