using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class Location
    {
        public string city { set; get; }
        public string street { set; get; }
        public string postalCode { set; get; }


        public Location(string city, string street, string postalCode) 
        {
            this.city = city;
            this.street = street;
            this.postalCode = postalCode;
        }
    }
}
