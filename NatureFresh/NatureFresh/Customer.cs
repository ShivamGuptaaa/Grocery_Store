
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
        string location;
        public string Location { 
            get{return location; }

          set{ location = value; } 
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

        
    }
    public enum Location
    {
        Dadar, Thane, Panvel, Chembur, Goregaon
    }
}
