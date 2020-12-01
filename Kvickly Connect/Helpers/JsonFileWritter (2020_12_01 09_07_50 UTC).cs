using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kvickly_Connect.Models;
using Newtonsoft.Json;

namespace Kvickly_Connect.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJson(Dictionary<int, Item> Dict, string JsonFileName)
        {

            string output = JsonConvert.SerializeObject(Dict);

            File.WriteAllText(JsonFileName, output);
        }
    }
}
