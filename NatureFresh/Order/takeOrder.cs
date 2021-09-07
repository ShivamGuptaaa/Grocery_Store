using System;
using System.Collections.Generic;
namespace Order
{
    public class takeOrder:Customer.Customer
    {
        public void setOrder(){
            Console.Write("Enter Customer ID: ");
            int custId = int.Parse(Console.ReadLine());
            
            Validation validate = new Validation();
            ItemDetails.printItem("potato");
            ItemDetails.printItem("orange carrot");
            ItemDetails.printItem("green peas");
            ItemDetails.printItem("onion");
            ItemDetails.printItem("cucumber");
            ItemDetails.printItem("lemon");

            Console.Write("\n\nEnter number of items to buy: ");
            int numItem = int.Parse(Console.ReadLine());
            string itemWeight="1", itemQnty;
            Dictionary<string, string[]> itemLst = new Dictionary<string, string[]>();
            for (int i = 0; i < numItem; i++)
            {
                Console.Write("\nEnter veggie name: ");
                string itemName = Console.ReadLine().ToLower();
                var item = ItemDetails.getItemObject(itemName);
                if (item["unit"].ToString() == "gram")
                {
                    Console.WriteLine("\nPlease choose in grams");
                    itemWeight = validate.checkWeight(Console.ReadLine());
                }
                Console.WriteLine("Please choose in units in range of (max 10)");
                itemQnty = validate.checkQuantity(int.Parse(Console.ReadLine()));

                itemLst.Add(itemName,new string[]{itemWeight, itemQnty});
                itemWeight = "1";
            }
            //foreach(var item in itemLst)
            //{
            //    Console.WriteLine($"{item.Key}:     {item.Value[0]} X {item.Value[1]} ");
            //}

            processOrder processOrder = new processOrder(itemLst,custId);
        }

        
            
    }
}
