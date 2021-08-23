using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace NatureFresh
{
    class ManagerFunctions
    {
        private static string CustomerJson = @"..//..//..//Json//CustomerDetails.json";
        private string HistoryJson = @"..//..//..//Json//OrderHistory.json";
        string center = ("\n \t\t\t\t\t\t\t\t\t");
        string center2 = ("\t\t\t\t\t\t\t\t");

        private void _DisplayAllCustomer()
        {
            var json = File.ReadAllText(CustomerJson);
            var JsonObject = JObject.Parse(json);
            foreach (var customer in JsonObject)
            {
                Console.WriteLine("\n" + center2 + "+--------+-------------------------------");
                Console.WriteLine($"{center2}|ID      | {customer.Value["id"]}");
                Console.WriteLine(center2 + "+--------+-------------------------------");
                Console.WriteLine($"{center2}|Name    | {customer.Value["name"]}");
                Console.WriteLine(center2 + "+--------+-------------------------------");
                Console.WriteLine($"{center2}|Address | {customer.Value["address"]}");
                Console.WriteLine(center2 + "+--------+-------------------------------");
                Console.WriteLine($"{center2}|Pin     | {customer.Value["pincode"]}");
                Console.WriteLine(center2 + "+--------+-------------------------------");
                Console.WriteLine($"{center2}|Mobile  | {customer.Value["phone"]}");
                Console.WriteLine(center2 + "+--------+-------------------------------");
                Console.WriteLine($"{center2}|Outlet  | {customer.Value["location"]}");
                Console.WriteLine(center2 + "+--------+-------------------------------\n");
            }
        }

        private void _SearchCustomer(string name)
        {
            var json = File.ReadAllText(CustomerJson);
            var JsonObject = JObject.Parse(json);
            foreach(var customer in JsonObject)
            {
                if(customer.Key == name)
                {
                    Console.WriteLine("\n" + center2 + "+--------+-------------------------------");
                    Console.WriteLine($"{center2}|ID      | {customer.Value["id"]}");
                    Console.WriteLine(center2 + "+--------+-------------------------------");
                    Console.WriteLine($"{center2}|Name    | {customer.Value["name"]}");
                    Console.WriteLine(center2 + "+--------+-------------------------------");
                    Console.WriteLine($"{center2}|Address | {customer.Value["address"]}");
                    Console.WriteLine(center2 + "+--------+-------------------------------");
                    Console.WriteLine($"{center2}|Pin     | {customer.Value["pincode"]}");
                    Console.WriteLine(center2 + "+--------+-------------------------------");
                    Console.WriteLine($"{center2}|Mobile  | {customer.Value["phone"]}");
                    Console.WriteLine(center2 + "+--------+-------------------------------");
                    Console.WriteLine($"{center2}|Outlet  | {customer.Value["location"]}");
                    Console.WriteLine(center2 + "+--------+-------------------------------\n");
                    return;
                }
            }
            Console.WriteLine("Customer not Registered!");
        }

        private void _DeleteCustomer(string name)
        {
            var json = File.ReadAllText(CustomerJson);
            var JsonObject = JObject.Parse(json);
            foreach (var customer in JsonObject)
            {
                if (customer.Key == name)
                {
                    return;
                }
            }
            Console.WriteLine("Customer does not exist");
        }

        private void _HistoryReader()
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
                Console.WriteLine(items);

                Console.WriteLine("\nTotal: " + entry.Value["total"].ToString());
            }
        }

        public void DisplayAllCustomer()
        {
            _DisplayAllCustomer();
        }

        public void SearchCustomer(string name)
        {
            _SearchCustomer(name);
        }

        public void DeleteCustomer(string name)
        {
            _DeleteCustomer(name);
        }

        public void DisplayAllHistory()
        {
            _HistoryReader();
        }
    }
}
