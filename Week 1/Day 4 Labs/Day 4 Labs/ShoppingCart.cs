using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Labs
{
    public class ShoppingCart
    {
        private List<CartItem> _items = new List<CartItem>();


        public void AddItem(string name, decimal price)
        {
            var item = new CartItem {Name = name, Price = price};
            this._items.Add(item);
        }

        public void RemoveItem(CartItem item)
        {
            //items.Remove(new String {});

        }

        public decimal GetTotal()
        {
            var total = 0m;
            foreach (var item in this._items) {
            total += item.Price;

        }
            return total;
        } 

        public IList<CartItem> GetAllItems()
        {
            return this._items;
        }
    }
}
