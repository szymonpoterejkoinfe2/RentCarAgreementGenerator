using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class Accessories
    {
        public bool abroad { set; get; }
        public bool insurance { set; get; }
        public bool kilometerLimit { set; get; }
        public bool carSeat { set; get; }
        public bool navi { set; get; }

        public Accessories(bool abroad, bool insurance, bool kilometerLimit,bool carSeat, bool navi)
        { 
            this.abroad = abroad;  
            this.insurance = insurance;
            this.kilometerLimit = kilometerLimit;
            this.carSeat = carSeat;
            this.navi = navi;
        }
    }
}
