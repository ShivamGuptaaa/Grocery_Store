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
            Console.Write("\nPlease choose a Location to order -\n press <0> for Dadar\n press <1> for Thane\n press <2> for Panvel\n press <3> for Chembur\n press <4> for Goregaon\n");
            int locationOption = int.Parse(Console.ReadLine());

            switch(locationOption)
            {

                case 0:
                    customer.Location = Convert.ToString(Location.Dadar);
                    break;
                case 1:
                    customer.Location = Convert.ToString(Location.Thane);
                    break;
                case 2:
                    customer.Location = Convert.ToString(Location.Panvel);
                    break;
                case 3:
                    customer.Location = Convert.ToString(Location.Chembur);
                    break;
                case 4:
                    customer.Location = Convert.ToString(Location.Goregaon);
                    break;
                default:
                    customer.Location = Convert.ToString(Location.Dadar);
                    break;
            }

            Console.WriteLine($"{customer.Id} {customer.Name} {customer.Address} {customer.Pincode} {customer.MobNum} {customer.Location}");
        }
    }
}
