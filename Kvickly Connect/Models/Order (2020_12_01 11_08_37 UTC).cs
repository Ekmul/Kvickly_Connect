using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kvickly_Connect.Models
{
    public class Order
    {
        public int OrderID;
        public Dictionary<int, Item> Items;
        public Customer customer;

        public double TotalPrice()
        {
            double price = 0;

            foreach (var item in Items)
            {
                
                price += item.Value.Price;
            }

            return price;
        }
    }
}
