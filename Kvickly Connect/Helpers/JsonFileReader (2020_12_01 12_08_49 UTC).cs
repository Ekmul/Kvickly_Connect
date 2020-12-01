using Kvickly_Connect.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Kvickly_Connect.Helpers
{
    public static class JsonFileReader
    {
        public static List<Customer> ReadCustomerJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<List<Customer>>(jsonString);
        }

        public static Dictionary<int, Item> ReadItemJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<Dictionary<int, Item>>(jsonString);
        }

        public static Dictionary<int, Order> ReadOrderJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<Dictionary<int, Order>>(jsonString);
        }
    }
}
