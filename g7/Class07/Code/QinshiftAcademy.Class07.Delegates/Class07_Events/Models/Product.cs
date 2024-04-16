using Class07_Events.Enums;

namespace Class07_Events.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public CategoryEnum Category { get; set; }
    }
}
