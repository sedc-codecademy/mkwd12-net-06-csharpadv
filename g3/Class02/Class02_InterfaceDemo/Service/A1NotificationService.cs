using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class A1NotificationService : NotificationService, INotificationService
    {
        public A1NotificationService()
        {
            Name = "A1";
        }

        public string SendSmsNotification(string phoneNumber, string message)
        {
            return $"Thank you for using our service, the message is sent. Your A1!";
        }
    }
}
