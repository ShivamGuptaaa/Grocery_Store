using System;
using System.Collections.Generic;

namespace NatureFresh
{
    class processOrder
    {
        VisualElements Velems = new VisualElements();
        internal processOrder(Dictionary<string, string[]> orderLst,string custName)//changed int custID -> string custName
        {
            Console.WriteLine("Test-ProcessOrder");
            Dictionary<string, string[]> newOrderList = new Dictionary<string, string[]>();     // structure (itemName,[unit,quantity,itemTotalPrice])
            int price=0;            //for individual item price
            int totPrice = 0;       //for total price of a order
            foreach (var item in orderLst)
            {
                var obj = ItemDetails.getItemObject(item.Key);          //obj stores object of json file
                int totQnty = (Convert.ToInt32(item.Value[0]) * Convert.ToInt32(item.Value[1]));        //total qnty of a item(weight/unit divide by quantity)
                if ((int)obj["quantity"] >= totQnty)        //checks if stocks value is larger than demand qauntity
                {
                    if ((string)obj["unit"] == "gram")
                    {
                        price = (totQnty / 1000) * (int)obj["price"];     //formula for finding total price of a item with unit gram
                    }
                    else
                    {
                        price = Convert.ToInt32(item.Value[1]) * (int)obj["price"];      //formula for finding total price of a item if unit is "pc" OR "bundle"
                    }
                    
                    newOrderList.Add(item.Key,new string[] {item.Value[0], item.Value[1], price.ToString()});       //Appends a item in new dictionary
                    int updatedStock = (int)obj["quantity"] - totQnty;
                    ItemDetails._UpdateItemStock(item.Key,updatedStock.ToString());         //decrement the stock value (existing stock - demanded quantity) and updates the json file
                } 
                else
                {
                    Console.WriteLine($"{item.Key}'s stock is not sufficient\n\n\n\n");
                }
            }

            if (newOrderList.Count != 0)
            {
                Console.WriteLine("\n\n\t\t\t\t"+Velems.CutBill+"\n");

                var cust = Customer.getCustomer(custName.ToString());

                Console.WriteLine("\n+--------------------------------------");
                Console.WriteLine($"| ID      | {cust["id"]}");
                Console.WriteLine("+--------------------------------------");
                Console.WriteLine($"| Name    | {cust["name"]}");
                Console.WriteLine("+--------------------------------------");
                Console.WriteLine($"| Address | {cust["address"]}");
                Console.WriteLine("+--------------------------------------");
                Console.WriteLine($"| Pincode | {cust["pincode"]}");
                Console.WriteLine("+--------------------------------------");
                Console.WriteLine($"| Phone   | {cust["phone"]}");
                Console.WriteLine("+--------------------------------------");
                Console.WriteLine($"| Outlet  | {cust["location"]}");
                Console.WriteLine("+--------------------------------------\n");

                foreach (var item in newOrderList)
                {
                    Console.WriteLine("\n-----------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n-"+item.Key.ToUpper());
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Grams : {item.Value[0]} gm");
                    Console.WriteLine($"Units : {item.Value[1]} unit");
                    Console.WriteLine($"Total : {item.Value[2]} Rs \n\n");

                    totPrice += Convert.ToInt32(item.Value[2]); //Calculate total price of a order
                }

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\t\t\t"+Velems.total);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(totPrice);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(Velems.total2);
                Console.ForegroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n"+Velems.OrderComplete);
                Console.ForegroundColor = ConsoleColor.Black;
                DateTime currDate = DateTime.Now;
                CustomerHistory saveData = new CustomerHistory();
                saveData.HistoryWriter(currDate.ToString(), newOrderList, totPrice.ToString());
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
            }
        }
     }
}
