using System;
using System.Text.RegularExpressions;
namespace NatureFresh

{
    class Validation
    {
        internal string name;
        internal string quantity;
        internal int quantValue;
        internal string weightOf;
        internal string loc;
        internal string phoneNumber;
        internal string pinCode;
        internal string[] location = { "Panvel", "Thane", "Chembur", "Goregaon", "Dadar" };
        internal string GetDetails()
        {
            bool success = int.TryParse(quantity, out quantValue);
            bool valid = success && 0 < quantValue && quantValue <= 10;
            while (!valid)
            {
                Console.WriteLine("\nInvalid quantity. Try again...");
                Console.WriteLine("\nPlease enter quantity in range(1-10): ");
                quantity = Console.ReadLine();
                success = int.TryParse(quantity, out quantValue);
                valid = 0 < quantValue && quantValue <= 10;
            }



            bool check = Array.Exists(location, x => x == loc);
            while (!check)
            {
                Console.WriteLine("\nLocation not found! Try again...");
                Console.WriteLine("\nPlease enter valid location ");
                quantity = Console.ReadLine();
                check = Array.Exists(location, x => x == loc);
            }


            Regex mobilePattern = new Regex(@"^[1-9]\d{10}$");


            if (mobilePattern.IsMatch(phoneNumber))
            {
                Console.WriteLine("\nSuccessfully entered mobile number!");
            }
            else
            {
                Console.WriteLine("\nInvalid mobile number! Try agian...");
            }



            Regex pinPattern = new Regex("^[1-9]{1}[0-9]{2}\\s{0, 1}[0-9]{3}$");
            if (pinPattern.IsMatch(pinCode))
            {
                Console.WriteLine("\nSuccessfully entered pincode!");
            }
            else
            {
                Console.WriteLine("\nInvalid pincode! Try again...");

            }


            return $"\n Your order Details : \n Weight(Quantity): {weightOf} kg ({quantity} Units)\n Location: {loc}\n Phone: {phoneNumber}\n Pincode: {pinCode}\n \n********THANKS FOR YOUR OREDR*********\n\n";
        }
    }

}

