using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Validation
    {
        internal string[] storeLocation = { "Panvel", "Thane", "Chembur", "Goregaon", "Dadar" };


        internal string checkName(string name)   // to check name (if name is empty it will return 0 value,otherwise it will return name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be blank,please enter your name!");
                name = Console.ReadLine();
                checkName(name);
            }

            return name;
        }

        internal string checkAddress(string Address)   // to check address (if address is empty it will return 0 value,otherwise it will return name)
        {
            if (string.IsNullOrEmpty(Address))
            {
                Console.WriteLine("Address can't be blank,please enter your address!");
                Address = Console.ReadLine();
                checkAddress(Address);
            }

            return Address;
        }

        internal string checkPhonenumber(string phoneNumber)  // to check valid mobile number
        {
            if ((phoneNumber.Length != 10) || (phoneNumber == null))
            {
                Console.WriteLine("Please enter your 10 digit mobile number!");
                phoneNumber = Console.ReadLine();
                checkPhonenumber(phoneNumber);
            }

            return phoneNumber;
        }


        internal string checkPincode(string pinCode) //to check valid pincode
        {
            if ((pinCode.Length != 6) || (pinCode == null))
            {
                Console.WriteLine("Wrong pincode,Please enter correct pincode!");
                pinCode = Console.ReadLine();
                checkPincode(pinCode);
            }

            return pinCode;
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
