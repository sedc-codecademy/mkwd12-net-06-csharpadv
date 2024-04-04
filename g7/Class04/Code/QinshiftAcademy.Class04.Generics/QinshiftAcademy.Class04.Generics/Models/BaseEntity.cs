

namespace QinshiftAcademy.Class04.Generics.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract string GetInfo();
    }
}
