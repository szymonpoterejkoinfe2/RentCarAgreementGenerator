using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class CarModel
    {
        public int modelId { get; set; }
        public string modelName { get; set; }
        public string brandName { get; set; }

        public CarModel(int id, string model, string brand) { 
        
            modelId = id;
            modelName = model;
            brandName = brand;

        }
    }
}
