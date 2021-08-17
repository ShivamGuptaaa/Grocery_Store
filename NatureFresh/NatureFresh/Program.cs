using System;
using System.Runtime.CompilerServices;


namespace NatureFresh
{
    class Program
    {
        static void Main(string[] args)
        {


            Validation val = new Validation();
            Console.Write("Please enter your name:");
            val.name = Console.ReadLine();
            Console.Write("Please enter item weight with quantity: ");
            val.quantity = Console.ReadLine();
            val.weightOf = Console.ReadLine();
            Console.Write("\nPlease select store Location: \n1.Panvel\n2.Chembur\n3.Thane\n4.Goregaon\n5.Dadar\n");
            val.loc = Console.ReadLine();
            Console.Write("\nPlease enter your 10 digit mobile number:");
            val.phoneNumber = Console.ReadLine();
            Console.Write("\nPlease enter your pincode:");
            val.pinCode = Console.ReadLine();

            Console.Write(val.GetDetails());
        }
    }
}
