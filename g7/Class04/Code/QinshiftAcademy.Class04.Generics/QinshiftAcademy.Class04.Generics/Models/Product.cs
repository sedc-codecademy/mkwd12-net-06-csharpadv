

namespace QinshiftAcademy.Class04.Generics.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string GetInfo()
        {
            return $"{Id} - {Title} - {Description}";
        }
    }
}
