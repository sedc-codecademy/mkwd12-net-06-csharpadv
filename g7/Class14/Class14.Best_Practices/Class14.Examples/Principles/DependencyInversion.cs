namespace Class14.Examples.Principles
{
    //bad example
    public class EmailMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            // will send an email
        }
    }

    public class SmsMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //will send SMS
        }
    }

    public class FacebookMessage
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }
        public void SendFacebookMessage()
        {
            // will send a facebook message
        }
    }

    public class Notification
    {
        private EmailMessage _email;
        private SmsMessage _sms;
        private FacebookMessage _facebook;
        public Notification()
        {
            _email = new EmailMessage();
            _sms = new SmsMessage();
            _facebook = new FacebookMessage();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
            _facebook.SendFacebookMessage();
        }
    }

    //good example
    public interface IMessage
    {
        void SendMessage();
    }

    public class Email : IMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            // .. code that will send an email
        }
    }

    public class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            // ... code that will send a message
        }
    }

    public class Facebook : IMessage
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            // ... code that will send a facebook message
        }
    }

    public class NotificationGood
    {
        private ICollection<IMessage> _messages;

        public NotificationGood(ICollection<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
