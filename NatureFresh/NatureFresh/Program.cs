using System;
namespace NatureFresh
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id,Unit;
            string itemWeight, Name, Address, PhoneNum, PinCode, locationOption; //Olocation=Outlet Location




            ItemDetails detail = new ItemDetails();
            detail.GetAllItems();
            detail.UpdateItemStock("potato", "20000");
            detail.GetItem();



            Customer customer = new Customer();
            validation validate = new validation();

            Console.WriteLine("Enter ID");
            Id=int.Parse(Console.ReadLine());
            //validate.check
            customer.Id = Id;

            Console.WriteLine("Enter Your name");
            Name = Console.ReadLine();
            customer.Name = validate.checkName(Name);

            Console.WriteLine("Enter Your address");
            Address = Console.ReadLine();
            customer.Address = Address;

            Console.WriteLine("Enter Your pincode");
            PinCode = Console.ReadLine();
            customer.Pincode = int.Parse(validate.checkPincode(PinCode));

            Console.WriteLine("Enter Your Mobile Number");
            PhoneNum = Console.ReadLine();
            customer.phoneNum = validate.checkPhonenumber(PhoneNum);


            Console.Write("\nPlease choose a Location to order from these locations only -\nDadar\nThane\nPanvel\nChembur\nGoregaon: ");
            locationOption= Console.ReadLine();
            customer.Location = validate.checkLocation(locationOption);

            Console.WriteLine("Please choose in grams");
            itemWeight=Console.ReadLine();
            customer.ItemWeight = int.Parse(validate.checkWeight(itemWeight));

            Console.WriteLine("Please choose in units in range of (1-10)");
            Unit = int.Parse(Console.ReadLine());
            customer.Unit = validate.checkQuantity(Unit);

            
              
            Console.WriteLine($"{customer.Id} {customer.Name} {customer.Address} {customer.Pincode} {customer.phoneNum} {customer.Location} {customer.ItemWeight} {customer.Unit}");

        }
    }
}
