using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class SmsNotificationSender : NotificationSender
    {
        public override void PrepareNotification()
        {
            Console.WriteLine("подготовка SMS уведомления...");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"отправка уведомления по SMS: \"{message}\"");
        }

        public override void ConfirmationSending()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SMS уведомление отправлено");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

