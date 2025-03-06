using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// заказ доставлен - никаких действий, он уже доставлен
    /// </summary>
    internal class DeliveredState : IState
    {
        public void ProcessOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ уже доставлен, нельзя обработать");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShipOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ уже доставлен, нельзя отправить");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DeliverOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("заказ уже доставлен");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CancelOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ уже доставлен, нельзя отменить");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
