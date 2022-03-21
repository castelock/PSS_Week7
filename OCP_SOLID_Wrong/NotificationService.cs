using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_SOLID_Wrong
{
    public class NotificationService
    {
        public async Task Send(List<Notification> notifications)
        {
            foreach (var notification in notifications)
            {
                if (notification.Type.Equals("sms"))
                {
                    await SendbySMS(notification.PhoneNumber, notification.Subject);
                }

                if (notification.Type.Equals("email"))
                {
                    await SendbyEmail(notification.Email, notification.Subject);
                }

                //If we want to add sending via WhatsApp or another channel in the near future,
                //we will have to add an additional if.

                if (notification.Type.Equals("whatsapp"))
                {
                    await SendbyWhatsApp(notification.PhoneNumber, notification.Subject);
                }

                if (notification.Type.Equals("slack"))
                {
                    await SendbySlack(notification.Channel, notification.Subject);
                }

                if (notification.Type.Equals("telegram"))
                {
                    await SendbyTelegram(notification.Channel, notification.Subject);
                }
            }
        }

        private Task SendbyTelegram(object channel, string subject)
        {
            throw new NotImplementedException();
        }

        private Task SendbySlack(object channel, string subject)
        {
            throw new NotImplementedException();
        }

        private Task SendbyWhatsApp(string phoneNumber, string subject)
        {
            throw new NotImplementedException();
        }

        private async Task SendbySMS(string phoneNumber, string subject)
        {
            // Code to send a SMS
        }

        private async Task SendbyEmail(string to, string subject)
        {
            // Code to send an email
        }
    }

    public class Notification
    {
        public object Type { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public string Subject { get; internal set; }
        public string Email { get; internal set; }
        public object Channel { get; internal set; }
    }
}
