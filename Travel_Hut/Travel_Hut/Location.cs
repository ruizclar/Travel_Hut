using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Hut
{
    class Location
    {
       //Variables for Location Class 
       public int LocationID { get; set; }
       public string LocationName { get; set; }
       public string Address { get; set; }
       public string City { get; set; }
       public int Zip { get; set; }


        //Default Constructor
        public Location()
        {
            LocationID = 0;
            LocationName = "unknown";
            Address = "unknown";
            City = "unkown";
            Zip = 0;
        }

        //Non-default constructor 

        public Location (int locationID, String locationName, String address, String city, int zip)
        {
            LocationID = locationID;
            LocationName = locationName;
            Address = address;
            City = city;
            Zip = zip;
        }

        public string listTravelInfo()
        {
            return ("Name of Location: " + LocationName + " is located at " + Address + ", " + City + ", " + Zip + ".");
        }

    }

}

    
  
