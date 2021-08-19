using System;
using System.Collections.Generic;

namespace NatureFresh
{
    class processOrder
    {
        Dictionary<string, string[]> orderLst = new Dictionary<string, string[]>();
        
        internal processOrder()
        {
            orderLst.Add("cucumber",new string[]{ "1000", "3" });
            orderLst.Add("potato", new string[] { "1000", "2" });
            orderLst.Add("lemon", new string[] { "1", "10" });
            orderLst.Add("spring onion", new string[] { "1", "2" });
            Dictionary<string, string[]> newOrderList = new Dictionary<string, string[]>();     // structure (itemName,[unit,quantity,itemTotalPrice])
            int price=0;            //for individual item price
            int totPrice = 0;       //for total price of a order
            foreach (var item in orderLst)
            {
                var obj = ItemDetails.getItemObject(item.Key);          //obj stores object of json file
                int totQnty = (Convert.ToInt32(item.Value[0]) * Convert.ToInt32(item.Value[1]));        //total qnty of a item(weight/unit divide by quantity)
                if ((int)obj["quantity"] >= totQnty)        //checks if stocks value is larger than demand qauntity
                {
                    if((string)obj["unit"]=="gram")
                        price = (totQnty / 1000) * (int)obj["price"];     //formula for finding total price of a item with unit gram
                    else
                        price = Convert.ToInt32(item.Value[1])* (int)obj["price"];      //formula for finding total price of a item if unit is "pc" OR "bundle"

                    newOrderList.Add(item.Key,new string[] {item.Value[0], item.Value[1], price.ToString()});       //Appends a item in new dictionary
                    int updatedStock = (int)obj["quantity"] - totQnty;      
                    ItemDetails._UpdateItemStock(item.Key,updatedStock.ToString());         //decrement the stock value (existing stock - demanded quantity) and updates the json file
                } 
                else
                {
                    //Console.WriteLine(obj["quantity"] + "impossible" + item.Value[1]);
                }
            }
            foreach(var item in newOrderList)
            {
                Console.WriteLine($"Name:{item.Key} Weight/Unit:{item.Value[0]} X Quantity:{item.Value[1] } = {item.Value[2]}");
                totPrice += Convert.ToInt32(item.Value[2]); //Calculate total price of a order
            }
            Console.WriteLine("Total price is: "+totPrice);
            DateTime currDate = DateTime.Now;
            Console.WriteLine(currDate);

        }


     }
}
