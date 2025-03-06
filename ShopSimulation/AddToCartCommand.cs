using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSimulation
{
    /// <summary>
    /// команда для добавления товара в корзину
    /// </summary>
    internal class AddToCartCommand : ICommand
    {
        private Cart _cart;
        private string _order;

        public AddToCartCommand(Cart cart, string order)
        {
            _cart = cart;
            _order = order;
        }

        public void Execute()
        {
            _cart.AddOrder(_order);
        }

        public void Undo()
        {
            _cart.RemoveOrder(_order);
        }
    }
}
