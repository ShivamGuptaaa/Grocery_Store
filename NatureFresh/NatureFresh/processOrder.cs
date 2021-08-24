using System;
using System.Collections.Generic;

namespace NatureFresh
{
    class processOrder
    {
        internal processOrder(Dictionary<string, string[]> orderLst,int custId)
        {
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
                        price = (int)(((double)totQnty / 1000) * (double)obj["price"]);     //formula for finding total price of a item with unit gram
                    }
                    else
                    {
                        price = Convert.ToInt32(item.Value[1]) * (int)obj["price"];      //formula for finding total price of a item if unit is "pc" OR "bundle"
                    Console.WriteLine($"Price of else is {price}");
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
                var cust = Customer.getCustomer(custId.ToString());
                Console.WriteLine("\n\n\nCustomer ID: " + cust["id"]);
                Console.WriteLine("Customer Name: " + cust["name"]);
                Console.WriteLine("Customer Address: "+ cust["address"]);
                Console.WriteLine("Customer Pincode: "+ cust["pincode"]);
                Console.WriteLine("Customer Phone: "+ cust["phone"]);
                Console.WriteLine("Store Outlet: "+cust["location"]);

                
                foreach (var item in newOrderList)
                {
                    Console.WriteLine($"\n{item.Key} \t{item.Value[0]}\t X \t{item.Value[1] } \t=\t {item.Value[2]}");
                    totPrice += Convert.ToInt32(item.Value[2]); //Calculate total price of a order
                }
                Console.WriteLine("\n\n\n\t\t\t\t***************Total price is: " + totPrice + "**************\n\n\n\n");
            DateTime currDate = DateTime.Now;
            CustomerHistory saveData = new CustomerHistory();
            saveData.HistoryWriter(currDate.ToString(), newOrderList, totPrice.ToString());
            }
        }
     }
}
