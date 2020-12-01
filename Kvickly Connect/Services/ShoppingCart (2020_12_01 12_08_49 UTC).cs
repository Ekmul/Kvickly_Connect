using Kvickly_Connect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kvickly_Connect.Services
{
    public class ShoppingCartService
    {
        List<Item> _cartItems;

        public ShoppingCartService()
        {
            _cartItems = new List<Item>();
        }

        public void Add(Item Item)
        {
            _cartItems.Add(Item);
        }

        public List<Item> GetOrderedItems()
        {
            return _cartItems;
        }

        public void RemoveItem(string isbn)
        {
            foreach (var Item in _cartItems)
            {
                if (Item.ItemID == isbn)
                {
                    _cartItems.Remove(Item);
                    break;
                }
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0.00M;

            foreach (var v in _cartItems)
            {
                totalPrice = totalPrice + (decimal)v.Price;
            }
            return totalPrice;
        }
    }
}
