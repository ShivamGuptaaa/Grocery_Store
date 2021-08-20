using System;
using System.Collections.Generic;

namespace NatureFresh
{
    class takeOrder:Customer
    {
        internal void setOrder(){

            validation validate = new validation();
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

            processOrder processOrder = new processOrder(itemLst);
        }

        internal void setCustomerDetails()
        {
            validation validate = new validation();

            //Console.WriteLine("\nEnter ID");
            //Id = int.Parse(Console.ReadLine());
            Id++;

            Console.WriteLine("\nEnter Your name");
            Name = validate.checkName(Console.ReadLine());

            Console.WriteLine("\nEnter Your address");
            Address = validate.checkAddress(Console.ReadLine());

            Console.WriteLine("\nEnter Your pincode");
            Pincode = int.Parse(validate.checkPincode(Console.ReadLine()));

            Console.WriteLine("\nEnter Your Mobile Number");
            PhoneNum = validate.checkPhonenumber(Console.ReadLine());


            Console.Write("\nPlease choose a Location to order from these locations only -\nDadar, Thane, Panvel, Chembur, Goregaon\nLocation:  ");
            Location = validate.checkLocation(Console.ReadLine());
            Console.WriteLine("\n\n");
        }
            
    }
}
