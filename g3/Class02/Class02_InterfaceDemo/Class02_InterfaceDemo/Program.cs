using Service;

namespace Class02_InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A1NotificationService a1Service = new A1NotificationService();

            NotificationService a1Service1 = new A1NotificationService();
            //TmobileService tmService = new TmobileService();

            //INotificationService notificationService = new A1NotificationService();
            //INotificationService notificationService1 = new TmobileService();

            Console.WriteLine("Choose:\n1) A1\n2)Tmobile");
            string input = Console.ReadLine();
            INotificationService notificationService;
            switch(input)
            {
                case "1":
                    notificationService = new A1NotificationService();
                    break;
                case "2":
                    notificationService = new TmobileService();
                    break;
                default:
                    notificationService = new A1NotificationService();
                    break;
            }

            string result = notificationService.SendSmsNotification("01232131", "Message");
            Console.WriteLine(result);


            NotificationService a1 = new A1NotificationService();
            NotificationService tM = new TmobileService();

            A1NotificationService a1_1 = (A1NotificationService)a1;
            //A1NotificationService tm_1 = (A1NotificationService)tM;


            //Boxing/Unboxing
            int t = 10;
            object o = t;
            object tm_2 = a1_1;
            int k = (int)o;
        }
    }
}
