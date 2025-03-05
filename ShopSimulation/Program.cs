namespace ShopSimulation
{
    /*
     * ФИО студента: Тамбовцева Александра
     * номер варианта: 5
     * условие задачи (скопировать из листа задания): Реализуйте симуляцию магазина, где пользователи могут выполнять команды "Добавить товар в корзину", "Удалить товар из корзины" и "Оформить заказ" с возможностью отмены операций.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            ICommand addOrder1Command = new AddToCartCommand(cart, "футболка");
            addOrder1Command.Execute();

            ICommand addOrder2Command = new AddToCartCommand(cart, "джинсы");
            addOrder2Command.Execute();

            Console.WriteLine();
            addOrder2Command.Undo(); 

            ICommand removeOrder1Command = new RemoveFromCartCommand(cart, "джинсы");
            removeOrder1Command.Execute();

            Console.WriteLine();
            ICommand checkoutCommand = new CheckoutCommand(cart);
            checkoutCommand.Execute();
        }
    }
}
