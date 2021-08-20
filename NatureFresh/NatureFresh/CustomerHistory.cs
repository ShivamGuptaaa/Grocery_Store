using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace NatureFresh
{
    class CustInfo 
    {
        public string id { get; set;}
        public string name { get; set; }
        public string date { get; set; }
        public Dictionary<string, string[]> items { get; set; }
        public string total { get; set; }
    }


    class CustomerHistory:Customer
    {
        private string HistoryJson = @"..//..//..//Json//OrderHistory.json";

        /*public void HistoryReader()
        {
            var json = File.ReadAllText(HistoryJson);
            var JObj = JObject.Parse(json);

            foreach (var entry in JObj)
            {
                Console.WriteLine("\nID: " + entry.Value["id"].ToString());
                Console.WriteLine("Name: " + entry.Value["name"].ToString());
                Console.WriteLine("Date: " + entry.Value["date"].ToString());

                var items = entry.Value["items"];
                Console.WriteLine("\nItems Purchased:");

                foreach (var item in items)
                {
                    Console.WriteLine("\n\t-Name: " + item["item"]);
                    Console.WriteLine("\t-Quantity: " + item["quantity"]);
                    Console.WriteLine("\t-Total: " + item["total"]);
                    Console.WriteLine("\t-Weight: " + item["weight"]);
                }
                Console.WriteLine("\nTotal: " + entry.Value["total"].ToString());
            }
        }*/
        public void HistoryWriter(string Custdate,Dictionary<string,string[]> Custitem,string Custtotal)
        {
            try
            {
                var json = File.ReadAllText(HistoryJson);
                CustInfo CI = new CustInfo
                {
                    id = Id.ToString(),
                    name = Name,

                    date = Custdate,
                    items = Custitem,
                    total = Custtotal
                };
                string res = JsonConvert.SerializeObject(CI, Formatting.Indented);
                File.AppendAllText(HistoryJson,res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

    }
}
