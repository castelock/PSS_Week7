using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_SOLID_Right
{
    public class NotificationService
    {
        public async Task Send(List<INotification> notifications)
        {
            foreach (var notification in notifications)
            {
                await notification.Notify();
            }
        }
    }
}
