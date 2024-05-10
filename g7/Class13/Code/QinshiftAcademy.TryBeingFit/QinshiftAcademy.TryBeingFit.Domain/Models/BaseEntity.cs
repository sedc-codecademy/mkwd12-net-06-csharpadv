

using QinshiftAcademy.TryBeingFit.Domain.DomainInterfaces;

namespace QinshiftAcademy.TryBeingFit.Domain.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
