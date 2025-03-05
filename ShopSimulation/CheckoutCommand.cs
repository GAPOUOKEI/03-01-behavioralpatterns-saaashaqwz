using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSimulation
{
    /// <summary>
    /// команда для оформления заказа
    /// </summary>
    internal class CheckoutCommand : ICommand
    {
        private Cart _cart;

        public CheckoutCommand(Cart cart)
        {
            _cart = cart;
        }

        public void Execute()
        {
            _cart.Checkout();
        }

        public void Undo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("нельзя отменить оформление заказа");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
