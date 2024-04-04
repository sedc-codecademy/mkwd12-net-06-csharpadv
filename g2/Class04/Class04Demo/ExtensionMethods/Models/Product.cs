namespace ExtensionMethods.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Product(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public string GetInfo()
        {
            return $"{Id}) {Title} - {Description}";
        }
    }
}
