using Kvickly_Connect.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Demo1_Json.Helpers
{
    public class JsonFileReader
    {
        public static Dictionary<int, Customer> ReadCostumerJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<Dictionary<int, Costumer>>(jsonString);
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
