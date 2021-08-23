using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureFresh
{
    class Portals:VisualElements
    {
        string center = ("\n\t\t\t\t\t\t\t\t");
        ItemDetails Idetails = new ItemDetails();
        ManagerFunctions MFunc = new ManagerFunctions();

        public void CustomerPanel()
        {
            while (true)
            {

                Console.WriteLine("\n\n"+CustomerPanelHeading);
                Console.WriteLine(CustomerOptions);
                takeOrder order = new takeOrder();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Enter Your choice: ");
                int option = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;


                if (option == 1)
                {
                    Console.WriteLine(RegisterFont);
                    order.setCustomerDetails();
                }
                else if (option == 2)
                {
                    while (true)
                    {
                        Console.WriteLine(ShopHeading);
                        Console.WriteLine(ShopOptions);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("Enter Your choice: ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        int shopOption = int.Parse(Console.ReadLine());
                        if (shopOption == 1)
                        {
                            Idetails.GetAllItems();
                        }
                        else if (shopOption == 2)
                        {
                            Idetails.GetItem();
                        }
                        else if (shopOption == 3)
                        {
                            order.setOrder();
                        }
                        else if (shopOption == 0) break;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(center + "-= Enter from the numbers given above! =-");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                }
                else if (option == 0) break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(center + "-= Enter from the numbers given above! =-");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
        }
        public void ManagerPanel()
        {
            while (true)
            {

                Console.WriteLine("\n\n" + ManagerPanelHeading);
                Console.WriteLine(ManagerOptions);

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Enter Your choice: ");
                int option = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;

                if (option == 1)
                {
                    Console.WriteLine(CustomersList);
                    MFunc.DisplayAllCustomer();
                    Console.WriteLine("Press Enter to Continue...");
                    Console.ReadLine();
                }
                else if (option == 2)
                {
                    Console.WriteLine(SearchACustomer);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\nEnter the name of a Customer: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string name = Console.ReadLine().ToLower();
                    MFunc.SearchCustomer(name);
                    Console.WriteLine("Press Enter to Continue...");
                    Console.ReadLine();
                }
                else if (option == 3)
                {
                    Console.WriteLine(SearchACustomer);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\nEnter the name of a Customer: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string name = Console.ReadLine().ToLower();
                    MFunc.DeleteCustomer(name);
                    Console.WriteLine("Press Enter to Continue...");
                    Console.ReadLine();
                }
                else if (option == 4)
                {
                    MFunc.DisplayAllHistory();
                }
                else if (option == 0) break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(center + "-= Enter from the numbers given above! =-");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
                Console.WriteLine("Manager");
        }
    }
}
