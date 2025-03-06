using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSimulation
{
    internal class Cart
    {
        private List<string> _orders = new List<string>();

        public void AddOrder(string order)
        {
            _orders.Add(order);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"товар \"{order}\" добавлен в корзину");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void RemoveOrder(string order)
        {
            if (_orders.Contains(order))
            {
                _orders.Remove(order);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"товар \"{order}\" удален из корзины");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"товар \"{order}\" не найден в корзине");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Checkout()
        {
            Console.WriteLine("оформление заказа...");
            foreach (var order in _orders)
            {
                Console.WriteLine($"товар: \"{order}\"");
            }
            _orders.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("заказ оформлен");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
