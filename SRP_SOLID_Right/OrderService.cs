using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP_SOLID_Right
{
    public class OrderService
    {
        private readonly NotificationService _notificationService;

        public OrderService(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task Add(Order order)
        {
            // 01. Código para crear la orden

            // 02. Notificar al cliente
            var message = new MailMessage(new MailAddress("sales@admin.com"), (MailAddress)order.ClientEmail)
            {
                Subject = "Se le asignó una compra",
                Body = "Estimado,\n Hemos creado su nueva orden de compra .."
            };

            await this._notificationService.SendEmail(message);
        }
    }

    public class Order
    {
        public object ClientEmail { get; internal set; }
    }
}
