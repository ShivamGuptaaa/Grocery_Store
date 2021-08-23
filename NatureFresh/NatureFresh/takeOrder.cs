using System;
using System.Collections.Generic;

namespace NatureFresh
{
    class takeOrder:Customer
    {
        VisualElements Velems = new VisualElements();
        internal void setOrder()
        {

            //Console.Write("\nEnter Customer ID: ");
            //int custId = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Customer name: ");
            string custName = Console.ReadLine().ToLower();

            validation validate = new validation();
            ItemDetails.printItem("potato");
            ItemDetails.printItem("orange carrot");
            ItemDetails.printItem("green peas");
            ItemDetails.printItem("onion");
            ItemDetails.printItem("cucumber");
            ItemDetails.printItem("lemon");

            //int numItem = int.Parse(Console.ReadLine());

            int numItem = numberChecker();

            string itemWeight = "1", itemQnty;
            Dictionary<string, string[]> itemLst = new Dictionary<string, string[]>();

            for (int i = 0; i < numItem; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\nEnter veggie name: ");
                Console.ForegroundColor = ConsoleColor.Black;
                string itemName = Console.ReadLine().ToLower();
                var item = ItemDetails.getItemObject(itemName);
                if (item["unit"].ToString() == "gram")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\nQuantity: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(Velems.Grams);
                    Console.ForegroundColor = ConsoleColor.Black;

                    itemWeight = validate.checkWeight(Console.ReadLine());
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nPlease choose in units in range of (max 10)");
                Console.ForegroundColor = ConsoleColor.Black;
                itemQnty = validate.checkQuantity(int.Parse(Console.ReadLine()));

                itemLst.Add(itemName, new string[] { itemWeight, itemQnty });
                itemWeight = "1";
            }
            //foreach(var item in itemLst)
            //{
            //    Console.WriteLine($"{item.Key}:     {item.Value[0]} X {item.Value[1]} ");
            //}

            processOrder processOrder = new processOrder(itemLst, custName);

        }

        public int numberChecker()
        {
            int res=1;
            string num;
            bool flag = false;
            while (!flag)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\n\nEnter number of items to buy: ");
                Console.ForegroundColor = ConsoleColor.Black;

                num = Console.ReadLine();
                if (int.TryParse(num, out int val))
                {
                    flag = true;
                    res = val;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a number, Try again");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            return res;
        }

        internal void setCustomerDetails()
        {
            validation validate = new validation();

            Id++;

            Console.Write("\nEnter Your name: ");
            Name = validate.checkName(Console.ReadLine());

            Console.Write("\nEnter Your address: ");
            Address = validate.checkAddress(Console.ReadLine());

            Console.Write("\nEnter Your pincode: ");
            Pincode = int.Parse(validate.checkPincode(Console.ReadLine()));

            Console.Write("\nEnter Your Mobile Number:");
            PhoneNum = validate.checkPhonenumber(Console.ReadLine());


            Console.Write("\nChoose a Location Nearest to you !");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Velems.locations);
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Location: ");
            Location = validate.checkLocation(Console.ReadLine());
            
            Console.WriteLine("\n\n");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t\t\t\t\t\t -= Registration done! Your ID is: "+Id);
            Console.ForegroundColor = ConsoleColor.Black;

            CustomerWrite();
        }
            
    }
}
