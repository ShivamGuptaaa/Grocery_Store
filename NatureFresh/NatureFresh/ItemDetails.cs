using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace NatureFresh
{
    class ItemDetails
    {
        string center = ("\n \t\t\t\t\t\t\t\t\t");
        string center2 = ("\t\t\t\t\t\t");
        //File path for ItemDetails.json. Modify the path according to the placement of json file.
        public static string detailsJson = @"..//..//..//json/ItemDetails.json";


        public static void printItem(string name)
        {
            var json = File.ReadAllText(detailsJson);
            var itemInput = name;
            var JsonObject = JObject.Parse(json);

            if (JsonObject[itemInput] != null)
            {
                var item = JsonObject[itemInput];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nName: " + itemInput.ToUpper());
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Price: " + item["price"]+"/"+ item["weight"] + item["unit"]);
            }
            else
            {
                Console.WriteLine(JsonObject[itemInput]);
                Console.WriteLine("\nThe item does not exist in the menu yet!");
            }
        }
        public static Newtonsoft.Json.Linq.JToken getItemObject(string itemInput)
        {
            var json = File.ReadAllText(detailsJson);
            var JsonObject = JObject.Parse(json);
            var item = JsonObject[itemInput];
            return item;
        }

        //Get a Specific item(To be upgraded to constructore)
        private void _GetItem()
        {
            var json = File.ReadAllText(detailsJson);
            Console.WriteLine("\nEnter the item you want to find");
            var itemInput = Console.ReadLine().ToLower();
            var JsonObject = JObject.Parse(json);

            if (JsonObject[itemInput] != null)
            {
                var item = JsonObject[itemInput];

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(center + itemInput.ToUpper());
                Console.ForegroundColor = ConsoleColor.Black;
                string Display = "| Price: " + item["price"] + " | Quantity: " + item["quantity"] + " | Weight: " + item["weight"] + " | Unit: " + item["unit"] + " |";
                Console.WriteLine(center2 + "-----------------------------------------------------------");
                Console.WriteLine(center2 + Display);
                Console.WriteLine(center2 + "-----------------------------------------------------------\n\n");
            }
            else
            {
                Console.WriteLine("\nThe item does not exist in the menu yet!");
            }
        }

        //Get All the items available in the Json/Database
        private void _GetAllItems()
        {
            var json = File.ReadAllText(detailsJson);
            var JsonObject = JObject.Parse(json);
            foreach (var item in JsonObject)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(center + item.Key.ToUpper());
                Console.ForegroundColor = ConsoleColor.Black;

                string Display = "| Price: " + item.Value["price"] + " | Quantity: " + item.Value["quantity"] + " | Weight: " + item.Value["weight"] + " | Unit: " + item.Value["unit"] + " |";
                Console.WriteLine(center2+ "-----------------------------------------------------------");
                Console.WriteLine(center2+Display);
                Console.WriteLine(center2+ "-----------------------------------------------------------\n\n");
            }
        }

        public static void _UpdateItemStock(string InputValue, string newValue)
        {
            InputValue = InputValue.ToLower();
            var json = File.ReadAllText(detailsJson);
            var JsonObject = JObject.Parse(json);

            foreach (var item in JsonObject)
            {
                if (item.Key == InputValue)
                {
                    try
                    {
                        item.Value["quantity"] = newValue;
                        string output = JsonConvert.SerializeObject(JsonObject, Formatting.Indented);
                        File.WriteAllText(detailsJson, output);
                        return; // Stop the function
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nError: " + e);
                        break;
                    }
                }
            }
            Console.WriteLine("\nItem not in inventory!");

        }

        //public methods calling the private ones
        public void GetItem()
        {
            _GetItem();
        }

        public void GetAllItems()
        {
            _GetAllItems();
        }

        //public void UpdateItemStock(string InputValue, string newValue)
        //{
        //    _UpdateItemStock(InputValue, newValue);
        //}



    }
}