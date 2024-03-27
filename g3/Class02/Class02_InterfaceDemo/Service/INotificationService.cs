namespace Service
{
    public interface INotificationService
    {
        //string Name { get; set; }
        string SendSmsNotification(string phoneNumber, string message);
    }
}
