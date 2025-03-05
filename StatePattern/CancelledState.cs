using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// заказ отменен - никаких действий, он уже отменен
    /// </summary>
    internal class CancelledState : IState
    {
        public void ProcessOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ отменен, нельзя обработать");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShipOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ отменен, нельзя отправить");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DeliverOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ отменен, нельзя доставить");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CancelOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("заказ уже отменен");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
