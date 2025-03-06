using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class PushNotificationSender : NotificationSender
    {
        public override void PrepareNotification()
        {
            Console.WriteLine("подготовка push уведомления...");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"отправка push уведомления: \"{message}\"");
        }

        public override void ConfirmationSending()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("push уведомление отправлено");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
