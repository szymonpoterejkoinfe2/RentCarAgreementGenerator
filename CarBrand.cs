using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class CarBrand
    {
        public int brandId { get; set; }
        public string brandName { get; set; }

        public CarBrand(int id, string name)
        {
            brandId = id;
            brandName = name;
        }
    }
}
