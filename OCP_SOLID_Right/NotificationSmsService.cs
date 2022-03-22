namespace OCP_SOLID_Right
{
    public class NotificationSmsService : INotification
    {
        private readonly string _phoneNumber;
        private readonly string _subject;

        public NotificationSmsService(string phoneNumber, string subject)
        {
            _phoneNumber = phoneNumber;
            _subject = subject;
        }

        public async Task Notify()
        {
            // Code to send the notification via SMS
        }
    }
}
