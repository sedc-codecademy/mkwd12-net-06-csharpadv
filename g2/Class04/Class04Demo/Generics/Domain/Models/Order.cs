using Generics.Domain.Models.BaseModel;

namespace Generics.Domain.Models
{
    public class Order : BaseEntity
    {
        public string Receiver { get; set; }
        public string Address { get; set; }

        public Order(int id, string receiver, string address)
        {
            Id = id;
            Receiver = receiver;
            Address = address;
        }

        public override string GetInfo()
        {
            return $"{Id}) {Receiver} - {Address}";
        }
    }
}
