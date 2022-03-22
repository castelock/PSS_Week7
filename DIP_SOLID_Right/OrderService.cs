using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_SOLID_Right
{
    public class OrderService
    {
        public readonly IMailService _mailService;

        public OrderService(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void Create(Order order)
        {
            // TODO: code to create the order

            // Send notification about the created order
            _mailService.Send();
        }
    }

    public class Order
    {
    }
}
