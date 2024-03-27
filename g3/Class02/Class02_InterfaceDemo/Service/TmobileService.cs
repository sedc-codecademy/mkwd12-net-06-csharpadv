using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TmobileService : NotificationService, INotificationService
    {
        public TmobileService()
        {
            Name = "TMobile";
        }

        public string SendSmsNotification(string phoneNumber, string message)
        {
            return "Thank you! T-Mobile";
        }
    }
}
