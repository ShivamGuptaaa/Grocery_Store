using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureFresh
{
    class Customer
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
       
       
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        int pincode;
        public int Pincode
        {
            get
            {
                return pincode;
            }
            set
            {
                pincode = value;
            }
        }

        string mobNum;
        public string MobNum
        {
            get
            {
                return mobNum;
            }
            set
            {
                mobNum = value;
            }
        }

        public List<string> chooseLocation()
        {
            List<string> loc = new List<string>();
            loc.Add(Convert.ToString(Location.Dadar));
            loc.Add(Convert.ToString(Location.Thane));
            loc.Add(Convert.ToString(Location.Panvel));
            loc.Add(Convert.ToString(Location.chembur));
            return loc;
        }

        /*List<string> location = new List<string>();
        location.Add*/

        public Location location { 
            get
            {
                return location;
            }
            set
            {
                location = value;
            } 
          }

        public enum Location
        {
            Dadar, Thane, Panvel, chembur, Goregaon
        }
    }
}
