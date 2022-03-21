using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP_SOLID_Right
{
    public class NotificationService
    {
        private readonly SmtpClient _smtpClient;

        public NotificationService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public async Task SendEmail(MailMessage message)
        {
            await _smtpClient.SendMailAsync(message);
        }
    }
}
