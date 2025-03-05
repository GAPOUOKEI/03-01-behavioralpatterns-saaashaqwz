using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// заказ в обработке - может быть отправлен в "службу доставки" или отменен
    /// </summary>
    internal class InProcessState : IState
    {
        public void ProcessOrder(Order order) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ уже в обработке");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShipOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("заказ отправлен");
            order.SetState(new ShippedState());
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DeliverOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ еще не отправлен, нельзя доставить");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CancelOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("заказ отменен");
            order.SetState(new CancelledState());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
