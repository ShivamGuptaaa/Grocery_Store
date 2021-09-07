using System;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Customer
{
    public class Customer
    {
        private static string CustomerJson = @"..//..//..//Json//CustomerDetails.json";

        static int id=100;
        public static int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        static string location;
        public static string Location { 
            get{return location; }

          set{ location = value; } 
        }

        static string name;
        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        static string address;
        public static string Address
        {
            get
            { return address; }
            set
            { address = value; }
        }

        static int pincode;
        public static int Pincode
        {
            get
            { return pincode; }
            set
            {   pincode = value; }
        }

        static string phonenum;
        public static string PhoneNum
        {
            get
            { return phonenum;}
            set
            { phonenum = value; }
        }

        public static Newtonsoft.Json.Linq.JToken getCustomer(string itemInput)
        {
            var json = File.ReadAllText(CustomerJson);
            var JsonObject = JObject.Parse(json);
            var item = JsonObject[itemInput];
            return item;
        }

        //Write the above details to a function during runtime
        public static void CustomerWrite()
        {
            try
            {
                var json = File.ReadAllText(CustomerJson).ToString();
                if (json.Length == 0)
                    json = "{";
                else
                    json = json.Substring(0, (json.Length - 1));
                File.WriteAllText(CustomerJson, json);
                CustomerDetail CD = new CustomerDetail
                {
                    id = Id.ToString(),
                    name = Name,
                    location = Location,
                    address = Address,
                    pincode = Pincode.ToString(),
                    phone = PhoneNum
                };
                string res = JsonConvert.SerializeObject(CD,Formatting.Indented);
                res = $"\"{Id}\": {res},";
                File.AppendAllText(CustomerJson, res+"}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        public void setCustomerDetails()
        {
            Validation validate = new Validation();

            Id++;

            Console.WriteLine("\nEnter Your name");
            Name = validate.checkName(Console.ReadLine());

            Console.WriteLine("\nEnter Your address");
            Address = validate.checkAddress(Console.ReadLine());

            Console.WriteLine("\nEnter Your pincode");
            Pincode = int.Parse(validate.checkPincode(Console.ReadLine()));

            Console.WriteLine("\nEnter Your Mobile Number");
            PhoneNum = validate.checkPhonenumber(Console.ReadLine());


            Console.Write("\nPlease choose a Location to order from these locations only -\nDadar, Thane, Panvel, Chembur, Goregaon\nLocation:  ");
            Location = validate.checkLocation(Console.ReadLine());
            Console.WriteLine("\n\n");
            CustomerWrite();
        }
    }
    class CustomerDetail {

        public string id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string address { get; set; }
        public string pincode { get; set; }
        public string phone { get; set; }
    }
        
}
