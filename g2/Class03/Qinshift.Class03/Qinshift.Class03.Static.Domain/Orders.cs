using Qinshift.Class03.Static.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Class03.Static.Domain
{
    public class Orders
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descripton { get; set; }
        public OrderStatus Status { get; set; }

        public Orders()
        {
            Status = OrderStatus.Processing;
        }

        public Orders(int id, string title, string descripton)
        {
            Id = id;
            Title = title;
            Descripton = descripton;
            Status = OrderStatus.Processing;
        }

        public Orders(int id, string title, string descripton, OrderStatus status)
        {
            Id = id;
            Title = title;
            Descripton = descripton;
            Status = status;
        }

        public string Print()
        {
            //CapitalFirsttter
            // We can use the helper class anywhere we need it without an instance
            return $"{Helper.CapitalFirstLetter(Title)} - {Descripton}";
        }
    }
}
