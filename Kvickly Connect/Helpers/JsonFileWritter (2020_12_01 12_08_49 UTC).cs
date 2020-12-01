using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kvickly_Connect.Models;
using Newtonsoft.Json;

namespace Kvickly_Connect.Helpers
{
    public static class JsonFileWritter
    {
        public static void WriteItemToJson(Dictionary<int, Item> Dict, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(Dict);

            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteCustomerToJson(List<Customer> List1, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(List1);

            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteOrderToJson(Dictionary<int, Order> Dict, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(Dict);

            File.WriteAllText(JsonFileName, output);
        }
    }
}
