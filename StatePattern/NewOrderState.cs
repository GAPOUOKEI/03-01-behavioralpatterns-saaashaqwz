using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// новый заказ - может быть отправлен в обработку или отменен
    /// </summary>
    internal class NewOrderState : IState
    {
        public void ProcessOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("заказ передан в обработку");
            order.SetState(new InProcessState());
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShipOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ еще не обработан, нельзя отправить");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DeliverOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("заказ еще не обработан, нельзя доставить");
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
