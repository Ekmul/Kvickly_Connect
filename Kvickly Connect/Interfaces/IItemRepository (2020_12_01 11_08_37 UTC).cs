using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kvickly_Connect.Models;

namespace Kvickly_Connect.Interfaces
{
    public interface IItemRepository
    {
        List<Item> GetAllItems();

        void AddItem(Item Item);

        Item GetItem(string isbn);
    }
}