//using System;
//using System.Collections.Generic;
//using Newtonsoft.Json.Linq;
//using Newtonsoft.Json;
//using System.IO;

<<<<<<< HEAD
namespace ConsoleApp1
{
    class ItemDetails
    {
        //File path for ItemDetails.json. Modify the path according to the placement of json file.
        //private string jsonFile = @"..//..//..//Json//ItemDetails.json";
        private string jsonFile = @"..//Grocery_Store//ItemDetails.json";
=======
//namespace ConsoleApp1
//{
//    class ItemDetails
//    {
//        //File path for ItemDetails.json. Modify the path according to the placement of json file.
//        private string jsonFile = @"..//..//..//Json//ItemDetails.json";
>>>>>>> 60fae8534da99a91fc29a12b5809b6ab62be91c0

//        //Get a Specific item(To be upgraded to constructore)
//        private void GetItem()
//        {
//            var json = File.ReadAllText(jsonFile);
//            Console.WriteLine("Enter the item you want to find");
//            var itemInput = Console.ReadLine().ToLower();
//            var JsonObject = JObject.Parse(json);

//            if (JsonObject[itemInput] != null)
//            {
//                var item = JsonObject[itemInput];
//                Console.WriteLine("\nID: " + item["id"]);
//                Console.WriteLine("Name: " + itemInput.ToUpper());
//                Console.WriteLine("Price: " + item["price"]);
//                Console.WriteLine("Weight: " + item["weight"]);
//                Console.WriteLine("Unit: " + item["unit"]);
//            }
//            else
//            {
//                Console.WriteLine("The item does not exist in the menu yet!");
//            }
//        }

//        private void GetAllItems()
//        {
//            var json = File.ReadAllText(jsonFile);
//            var JsonObject = JObject.Parse(json);
            
//            foreach (var item in JsonObject)
//            {
//                Console.WriteLine("\n" + item.Key.ToUpper());
//                Console.WriteLine("-Price: " + item.Value["price"]);
//                Console.WriteLine("-Weight: " + item.Value["weight"]);
//                Console.WriteLine("-Unit: " + item.Value["unit"]);
//            }
//        }

//        public void GetItemDetails()
//        {
//            GetItem();
//        }

//        public void GetAllItemDetails()
//        {
//            GetAllItems();
//        }

//        public int id { get; set; }
//        public int price { get; set; }
//        public int stock { get; set; }


//    }
//}
