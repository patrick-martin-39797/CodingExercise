using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleApp
{
    public class Cart
    {
        private List<CartItem> _items = new List<CartItem>();

        public TypeOfCart TypeOfCart { get; set; }

        public int NumberOfItems => _items.Count;

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
            foreach (CartItem item in _items)
            {
                if (item.UnitPrice.HasValue)
                {
                    if (item.Weight.HasValue)
                    {
                        totalPrice += (item.Weight.Value * item.UnitPrice.Value);
                    } 
                    else
                    {
                        totalPrice += (item.Quantity * item.UnitPrice.Value);
                    }
                }
                else
                {
                    throw new Exception("Items in the cart must have a unit price.");
                }
            }
            return totalPrice;
        }

        public string Contents()
        {
            return string.Join(", ", _items.Select(i => i.Description));
        }

        public void AddItem(CartItem cartItem)
        {
            this._items.Add(cartItem);
        }
    }
}