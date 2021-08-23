using System;
using System.Collections.Generic;
namespace NatureFresh
{
    class Program
    {
        //////////////////////////////////////////////////////////
        //Change the Console Background Colour to white
        //Right Click on title bar -> Properties -> Select Backgrund colour option on upper left -> Choose White from colour list(last colour)
        //////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            VisualElements Velems = new VisualElements();
            Portals portal = new Portals();

            Velems.IntroScreen();


            string center = ("\n\t\t\t\t\t\t\t\t");
            int choice = 10;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t\t\t\t\t\t\t\t\t Portal Selection");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(Velems.MainOptions);
                Console.Write(center + "\tEnter your choice: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1) portal.CustomerPanel();
                else if (choice == 2) portal.ManagerPanel();
                else if (choice == 0) break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(center + Velems.ErorrMsg);
                }
            }

        }
    }
}

//Modified Program 
//Added Portals.cs and VisualElements.cs
//Modified takeOrder.cs