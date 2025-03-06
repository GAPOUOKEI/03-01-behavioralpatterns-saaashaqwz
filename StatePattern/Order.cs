using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Order
    {
        private IState _state;

        public Order()
        {
            _state = new NewOrderState();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ProcessOrder()
        {
            _state.ProcessOrder(this);
        }

        public void ShipOrder()
        {
            _state.ShipOrder(this);
        }

        public void DeliverOrder()
        {
            _state.DeliverOrder(this);
        }

        public void CancelOrder()
        {
            _state.CancelOrder(this);
        }
    }
}

