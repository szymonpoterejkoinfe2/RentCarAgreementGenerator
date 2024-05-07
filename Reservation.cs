using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class Reservation
    {
        public int reservationNumber { set; get; }
        public DateTime pickUpDate { set; get; }
        public DateTime returnDate { set; get; }

    }
}
