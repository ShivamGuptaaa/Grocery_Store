using System;
namespace NatureFresh
{
    class validation
    {

        internal string[] storeLocation = { "Panvel", "Thane", "Chembur", "Goregaon", "Dadar" };
        internal string[] weightList = { "1000", "500", "250", "1" };


        internal string checkName(string name)   // to check name (if name is empty it will return 0 value,otherwise it will return name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nName can't be blank,please enter your name!\n");
                Console.ForegroundColor = ConsoleColor.Black;
                name = Console.ReadLine();
                checkName(name);
            }

            return name;
        }

        internal string checkAddress(string Address)   // to check address (if address is empty it will return 0 value,otherwise it will return name)
        {
            if (string.IsNullOrEmpty(Address))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nAddress can't be blank,please enter your address!\n");
                Console.ForegroundColor = ConsoleColor.Black;
                Address = Console.ReadLine();
                checkAddress(Address);
            }

            return Address;
        }

        internal string checkPhonenumber(string phoneNumber)  // to check valid mobile number
        {
            if ((phoneNumber.Length != 10) || (phoneNumber == null))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nPlease enter your 10 digit mobile number!\n");
                Console.ForegroundColor = ConsoleColor.Black;
                phoneNumber = Console.ReadLine();
                checkPhonenumber(phoneNumber);
            }

            return phoneNumber;
        }


        internal string checkPincode(string pinCode) //to check valid pincode
        {
            if ((pinCode.Length != 6) || (pinCode == null))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nWrong pincode,Please enter correct pincode!\n");
                Console.ForegroundColor = ConsoleColor.Black;
                pinCode = Console.ReadLine();
                checkPincode(pinCode);
            }

            return pinCode;
        }


        internal string checkWeight(string itemWeight) //to check valid item weight
        {
            bool check = Array.Exists(weightList, x => x == itemWeight); // it should be 1000gm or 500gm or 250gm or 1 bundle
            if (!check)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nPlease enter valid item weight (1000gm, 500gm, 250gm or 1 bundle)!\n");
                Console.ForegroundColor = ConsoleColor.Black;
                itemWeight = Console.ReadLine();
                checkWeight(itemWeight);
            }

            return itemWeight;
        }


        internal string checkQuantity(int itemQuantity) //to check item quantity
        {
            if (!(itemQuantity > 0 && itemQuantity <= 10)) //range of item quantity should be between 1 to 10
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Please enter item quantity range beetween 1-10!");
                Console.ForegroundColor = ConsoleColor.Black;
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You entered wrong store location,Please enter correct store locaton!");
                Console.ForegroundColor = ConsoleColor.Black;
                location = Console.ReadLine();
                checkLocation(location);
            }

            return location;
        }

    }

}

