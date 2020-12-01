using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kvickly_Connect.Models;
using Kvickly_Connect.Helpers;
using Newtonsoft.Json;
using Kvickly_Connect.Interfaces;

namespace Kvickly_Connect.Services
{
    public class JsonItemRepository
    {
        string JsonFileName = @"AFilePath";

        public List<Item> GetAllItems()
        {
            return null; //JsonFileReader.ReadItemJson(JsonFileName);
        }
        public void AddItem(Item item)
        {
            List<Item> items = GetAllItems().ToList();
            items.Add(item);
            //JsonFileWritter.WriteToJson(items, JsonFileName);
        }

    }
}
