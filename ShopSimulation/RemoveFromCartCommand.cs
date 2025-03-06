using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSimulation
{
    /// <summary>
    /// команда для удаления товара в корзину
    /// </summary>
    internal class RemoveFromCartCommand : ICommand
    {
        private Cart _cart;
        private string _order;

        public RemoveFromCartCommand(Cart cart, string order)
        {
            _cart = cart;
            _order = order;
        }

        public void Execute()
        {
            _cart.RemoveOrder(_order);
        }

        public void Undo()
        {
            _cart.AddOrder(_order);
        }
    }
}
