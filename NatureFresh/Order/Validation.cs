using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Validation
    {

        internal string[] storeLocation = { "Panvel", "Thane", "Chembur", "Goregaon", "Dadar" };
        internal string[] weightList = { "1000", "500", "250", "1" };
        internal string checkWeight(string itemWeight) //to check valid item weight
        {
            bool check = Array.Exists(weightList, x => x == itemWeight); // it should be 1000gm or 500gm or 250gm or 1 bundle
            if (!check)
            {
                Console.WriteLine("Please enter valid item weight (1000gm, 500gm, 750gm, 250gm or 1 bundle)!");
                itemWeight = Console.ReadLine();
                checkWeight(itemWeight);
            }

            return itemWeight;
        }


        internal string checkQuantity(int itemQuantity) //to check item quantity
        {
            if (!(itemQuantity > 0 && itemQuantity <= 10)) //range of item quantity should be between 1 to 10
            {
                Console.WriteLine("Please enter item quantity range beetween 1-10!");
                itemQuantity = int.Parse(Console.ReadLine());
                checkQuantity(itemQuantity);
            }

            return itemQuantity.ToString();
        }


        internal string checkLocation(string location) // to check store location is valid or not
        {
            bool check = Array.Exists(storeLocation, x => x == location);  // check input location is exists in store location or not
            if (!check)
            {
                Console.WriteLine("You entered wrong store location,Please enter correct store locaton!");
                location = Console.ReadLine();
                checkLocation(location);
            }

            return location;
        }
    }
}
