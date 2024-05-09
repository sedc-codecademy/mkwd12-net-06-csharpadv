// See https://aka.ms/new-console-template for more information
using Principles.SOLID;

Console.WriteLine("Hello, World!");

AppStartWithoutLSP.Main(); // Circle
Console.WriteLine();
AppStartWithLSP.Main(); // Triangle

List<IMessage> messages = new List<IMessage>()
{
    new Facebook(),
    new Sms(),
    new Email(),
};
NotificationService notificationService = new NotificationService(messages);
notificationService.Send();