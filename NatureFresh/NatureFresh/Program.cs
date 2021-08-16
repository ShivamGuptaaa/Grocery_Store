using System;
using System.Collections.Generic;

namespace NatureFresh
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter ID");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your name");
            customer.Name=Console.ReadLine();
            Console.WriteLine("Enter Your address");
            customer.Address = Console.ReadLine();
            Console.WriteLine("Enter Your pincode");
            customer.Pincode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Mobile Number");
            customer.MobNum = Console.ReadLine();
            Console.Write("\nPlease choose a Location to order -\n press <0> for Dadar\n press <1> for Thane\n press <2> for Panvel\n press <3> for Chembur\n press <4> for Goregaon");
            int locationOption = int.Parse(Console.ReadLine());
            if (locationOption == 0)
                customer.location = Customer.Location.Dadar;
            else if(locationOption == 1)
                customer.location = Customer.Location.Thane;
            else if (locationOption == 2)
                customer.location = Customer.Location.Panvel;
            else if (locationOption == 3)
                customer.location = Customer.Location.chembur;
            else if (locationOption == 4)
                customer.location = Customer.Location.Goregaon;


        }
    }
}
