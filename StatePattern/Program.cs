namespace StatePattern
{
    /*
     * ФИО студента: Тамбовцева Александра
     * номер варианта: 5
     * условие задачи (скопировать из листа задания): Спроектируйте систему обработки заказов с состояниями, такими как "Новый заказ", "В обработке", "Отправлено", "Доставлено", "Отменено". Изменение состояния должно определять доступные действия.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();

            Console.WriteLine("Первый заказ:");
            order1.ProcessOrder();
            order1.ShipOrder();
            order1.DeliverOrder();
            order1.CancelOrder();

            Console.WriteLine("\nВторой заказ:");
            order2.ProcessOrder();
            order2.CancelOrder();
            order2.ShipOrder();
            order2.DeliverOrder();

            Console.WriteLine("\nТретий заказ:");
            order3.ProcessOrder();
            order3.ShipOrder();
            order3.CancelOrder();
            order3.DeliverOrder();
        }
    }
}
