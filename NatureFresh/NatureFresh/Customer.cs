using System;
using System.Collections.Generic;
namespace NatureFresh
{
    class Customer
    {
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
    }
}
