using System;
using System.Text.RegularExpressions;
namespace NatureFresh

{
    class validation
    {
        
        internal string[] storeLocation = { "Panvel", "Thane", "Chembur", "Goregaon", "Dadar" };
        internal string[] weightList = { "1000", "500" ,"250","1"};
        
            
        internal string checkName(string name)   // to check name (if name is empty it will return null value,otherwise it will return name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return ("null");
            }
            else
            {
                return name;
            }
        } 

        internal string checkPhonenumber(string phoneNumber)  // to check valid mobile number
        {
            Regex mobilePattern = new Regex("(?:(?:\\+|0{0,2})91(\\s*[\\- ]\\s*)?|[0 ]?)?[789]\\d{9}|(\\d[ -]?){10}\\d"); //mobile number should match this pattern(eg.9436728123)

            if (mobilePattern.IsMatch(phoneNumber))
            {
                return phoneNumber;
            }
            else
            {
                return null;
            }
        }


        internal string checkPincode(string pinCode) //to check valid pincode
        {
            Regex pinPattern = new Regex("^[1-9]{1}[0-9]{2}\\s{0, 1}[0-9]{3}$"); //pincode should match this pattern

            if (pinPattern.IsMatch(pinCode))
            {
                return pinCode;
            }
            else
            {
                return null;
            }
        }



        internal string checkWeight(string itemWeight) //to check valid item weight
        {
            bool check = Array.Exists(weightList, x => x == itemWeight); // it should be 1000gm or 500gm or 250gm or 1 bundle
            if (!check)
            {
                return null;
            }
            else
            {
                return itemWeight;
            }
        }


        internal int checkQuantity(int itemQuantity) //to check item quantity
        {
           
            if (itemQuantity > 0 && itemQuantity<=10) //range of item quantity should be between 1 to 10
            {
                return itemQuantity;
            }
            else
            {
                return 0;
            }
        }


        internal string checkLocation(string location) // to check store location is valid or not
        {
            bool check = Array.Exists(storeLocation, x => x == location);  // check input location is exists in store location or not
            if (!check)
            {
                return null;               
            }
            else
            {
                return location;
            }
                
        }
        
        
        
    }

}

