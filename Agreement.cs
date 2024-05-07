using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class Agreement
    {
        Client client { set; get; }
        Location pickUpLocation { set; get; }
        Location returnLocation { set; get; }
        Accessories accessories { set; get; }
        Car car { set; get; }
    }
}
