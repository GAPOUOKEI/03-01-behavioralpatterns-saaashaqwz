using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// заказ доставляется - может только быть доставлен
    /// </summary>
    internal class ShippedState : IState
    {
        public void ProcessOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ уже отправлен, нельзя обработать");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShipOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ уже отправлен");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DeliverOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("заказ доставлен");
            order.SetState(new DeliveredState());
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CancelOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ уже отправлен, нельзя отменить");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
