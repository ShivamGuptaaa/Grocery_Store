using System;
using System.Collections.Generic;

namespace NatureFresh
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id,PinCode,LocationNum,itemWeight,Unit, locationOption;
            string Name, Address, PhoneNum,Olocation; //Olocation=Outlet Location

            //Validation val = new Validation();
            //Console.Write(val.GetDetails());
            Customer customer = new Customer();

            Console.WriteLine("Enter ID");
            Id=int.Parse(Console.ReadLine());
            customer.Id = Id;

            Console.WriteLine("Enter Your name");
            Name = Console.ReadLine();
            customer.Name=Name;

            Console.WriteLine("Enter Your address");
            Address = Console.ReadLine();
            customer.Address = Address;

            Console.WriteLine("Enter Your pincode");
            PinCode = int.Parse(Console.ReadLine());
            customer.Pincode = PinCode;

            Console.WriteLine("Enter Your Mobile Number");
            PhoneNum = Console.ReadLine();
            customer.phoneNum = PhoneNum;

            Console.Write("\nPlease choose a Location to order -\n press <0> for Dadar\n press <1> for Thane\n press <2> for Panvel\n press <3> for Chembur\n press <4> for Goregaon\n");
            LocationNum= int.Parse(Console.ReadLine());
            locationOption = LocationNum;

            Console.WriteLine("Please choose in grams");
            itemWeight=int.Parse(Console.ReadLine());
            customer.ItemWeight = itemWeight;

            Console.WriteLine("Please choose in units in range of (1-10)");
            Unit = int.Parse(Console.ReadLine());
            customer.Unit = Unit;

            
            switch (locationOption)
            {

                case 0:
                    Olocation = Convert.ToString(Location.Dadar);
                    customer.Location = Olocation;
                    break;
                case 1:
                    Olocation = Convert.ToString(Location.Thane);
                    customer.Location = Olocation;
                    break;
                case 2:
                    Olocation = Convert.ToString(Location.Panvel);
                    customer.Location = Olocation;
                    break;
                case 3:
                    Olocation = Convert.ToString(Location.Chembur);
                    customer.Location = Olocation;
                    break;
                case 4:
                    Olocation = Convert.ToString(Location.Goregaon);
                    customer.Location = Olocation;
                    break;
                default:
                    Olocation = Convert.ToString(Location.Dadar);
                    customer.Location = Olocation;
                    break;
            }
              
            Console.WriteLine($"{customer.Id} {customer.Name} {customer.Address} {customer.Pincode} {customer.phoneNum} {customer.Location} {customer.ItemWeight} {customer.Unit}");
            //Console.WriteLine($"{Id} {Name} {Address} {PinCode} {PhoneNum} {Olocation} {Wei}");

        }
    }
}
