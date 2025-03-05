namespace TemplateMethod
{
    /*
     * ФИО студента: Тамбовцева Александра
     * номер варианта: 5
     * условие задачи (скопировать из листа задания): Напишите приложение, которое отправляет уведомления различными способами (по электронной почте, SMS, через push-уведомления), используя шаблонный метод для общего алгоритма отправки.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationSender emailSender = new EmailNotificationSender();
            NotificationSender smsSender = new SmsNotificationSender();
            NotificationSender pushSender = new PushNotificationSender();

            emailSender.SendNotification("Вы можете забрать свою посылку");
            Console.WriteLine();
            smsSender.SendNotification("Вы можете забрать свою посылку");
            Console.WriteLine();
            pushSender.SendNotification("Вы можете забрать свою посылку");
        }
    }
}
