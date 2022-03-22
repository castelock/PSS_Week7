using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_SOLID_Right
{
    public class NotificationEmailService:INotification
    {
        private readonly string _to;
        private readonly string _subject;

        public NotificationEmailService(string to, string subject)
        {
            _to = to;
            _subject = subject;
        }

        public async Task Notify()
        {
            // Code to send the notification via e-mail
        }
    }

    
}
