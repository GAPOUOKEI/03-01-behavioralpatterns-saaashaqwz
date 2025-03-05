using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class NotificationSender
    {
        public abstract void PrepareNotification();
        public abstract void Send(string message);
        public abstract void ConfirmationSending();

        /// <summary>
        /// шаблонный метод
        /// </summary>
        public void SendNotification(string message)
        {
            PrepareNotification();
            Send(message);
            ConfirmationSending();
        }
    }
}
