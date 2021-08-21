using System;
using System.Collections.Generic;
namespace NatureFresh
{
    class Program
    {

        static void Main(string[] args)
        {
             while (true)
             {
                 Console.WriteLine("0. Entering customer details");
                 Console.WriteLine("1. To place order");
                 int option = int.Parse(Console.ReadLine());
                 takeOrder order = new takeOrder();
                 if (option == 0)
                     order.setCustomerDetails();
                 else if (option == 1)
                     order.setOrder();
                 else
                     Console.WriteLine("Enter correct option");

             }
        }
    }
}
