using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NatureFresh
{
    class Customer
    {
        private string CustomerJson = @"..//..//..//Json//CustomerDetails.json";

        static int id=100;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        static string location;
        public string Location { 
            get{return location; }

          set{ location = value; } 
        }

        static string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        static string address;
        public string Address
        {
            get
            { return address; }
            set
            { address = value; }
        }

        static int pincode;
        public int Pincode
        {
            get
            { return pincode; }
            set
            {   pincode = value; }
        }

        static string phonenum;
        public string PhoneNum
        {
            get
            { return phonenum;}
            set
            { phonenum = value; }
        }

        //Write the above details to a function during runtime
        internal void CustomerWrite(string Id, string Name, string Location, string Address, string Pincode, string PhoneNum)
        {
            try
            {
                var json = File.ReadAllText(CustomerJson);
                CustomerDetail CD = new CustomerDetail
                {
                    id = Id.ToString(),
                    name = Name,
                    location = Location,
                    address = Address,
                    pincode = Pincode.ToString(),
                    phone = PhoneNum
                };
                string res = JsonConvert.SerializeObject(CD, Formatting.Indented);
                File.AppendAllText(CustomerJson, res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
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
