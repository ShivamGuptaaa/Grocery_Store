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
        //public string orderNo { get; set; }
        public string id { get; set;}
        public string name { get; set; }
        public string date { get; set; }
        public Dictionary<string, string[]> items { get; set; }
        public string total { get; set; }
    }


    class CustomerHistory:Customer
    {
        private static string HistoryJson = @"..//..//..//Json//OrderHistory.json";

        internal void HistoryWriter(string Custdate,Dictionary<string,string[]> Custitem,string Custtotal)
        {
            try
            {
                var json = File.ReadAllText(HistoryJson);
                if (json.Length == 0)
                    json = "{}";
                else
                    json = json.Substring(0, (json.Length - 1));
                File.WriteAllText(HistoryJson, json);
                CustInfo CI = new CustInfo
                {
                    id = Id.ToString(),
                    name = Name.ToLower(),
                    date = Custdate,
                    items = Custitem,
                    total = Custtotal
                };

                string res = JsonConvert.SerializeObject(CI, Formatting.Indented);
                res = $"\"{Name.ToLower()}\": {res},";
                File.AppendAllText(HistoryJson,res + "}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("eRroR:"+ ex);
            }
        }

    }
}
