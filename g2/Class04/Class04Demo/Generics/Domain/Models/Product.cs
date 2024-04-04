using Generics.Domain.Models.BaseModel;

namespace Generics.Domain.Models
{
    public class Product : BaseEntity
    { 
        public string Title { get; set; }
        public string Description { get; set; }

        public Product(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public override string GetInfo()
        {
            return $"{Id}) {Title} - {Description}";
        }
    }
}
