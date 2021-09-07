using System;
using Order;
using Customer;
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
                Customer.Customer cust = new Customer.Customer();
                 if (option == 0)
                     cust.setCustomerDetails();
                 else if (option == 1)
                     order.setOrder();
                 else
                     Console.WriteLine("Enter correct option");

             }
        }
    }
}
