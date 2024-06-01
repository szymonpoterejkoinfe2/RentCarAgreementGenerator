using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class Car
    {
        public int carId { set; get; }
        public string carBrand { set; get; }
        public string carModel { set; get; }
        public string carRegistration { set; get; }

        public Car(int id, string brand,string model, string registration) { 
            carId = id;
            carBrand = brand;
            carModel = model;
            carRegistration = registration;
        }

    }
}
