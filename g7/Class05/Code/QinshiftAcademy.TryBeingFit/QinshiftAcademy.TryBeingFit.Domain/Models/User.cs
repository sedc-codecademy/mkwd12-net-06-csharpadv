

using QinshiftAcademy.TryBeingFit.Domain.Enums;

namespace QinshiftAcademy.TryBeingFit.Domain.Models
{
    public abstract class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserType Type { get; set; }
    }
}
