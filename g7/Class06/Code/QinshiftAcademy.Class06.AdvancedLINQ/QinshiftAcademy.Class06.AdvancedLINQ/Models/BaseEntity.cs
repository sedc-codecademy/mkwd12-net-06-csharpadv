

namespace QinshiftAcademy.Class06.AdvancedLINQ.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract void PrintInfo(); 
    }
}
