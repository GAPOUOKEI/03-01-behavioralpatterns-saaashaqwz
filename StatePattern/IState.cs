using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal interface IState
    {
        void ProcessOrder(Order order);
        void ShipOrder(Order order);
        void DeliverOrder(Order order);
        void CancelOrder(Order order);
    }
}
