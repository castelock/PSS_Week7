using OCP_SOLID_Wrong;

var email = new Notification
{
    Type = "email",
    Email = "customer@email.com",
    Subject = "El asunto del correo"
};

var sms = new Notification
{
    Type = "sms",
    PhoneNumber = "+051199999999",
    Subject = "El mensaje del texto"
};

var notificationService = new NotificationService();
await notificationService.Send(new List<Notification> { email, sms });