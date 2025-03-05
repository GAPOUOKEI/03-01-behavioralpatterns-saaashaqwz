using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class EmailNotificationSender : NotificationSender
    {
        public override void PrepareNotification()
        {
            Console.WriteLine("подготовка email уведомления...");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"отправка уведомления по email: \"{message}\"");
        }

        public override void ConfirmationSending()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("еmail уведомление отправлено");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
