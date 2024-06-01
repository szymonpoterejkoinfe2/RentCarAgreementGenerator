using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class RentPeriods
    {
        // 1-3,3-5,5-7,7-14,14+
        public int lengthOneToThree { set; get; } = 0;
        public int lengthThreeToFive { set; get; } = 0;
        public int lengthFiveToSeven { set; get; } = 0;
        public int lengthSevenToFourteen { set; get; } = 0;
        public int lengthFourteenPlus { set; get; } = 0;
        public void SetRentPeriods(List<TimeSpan> timeSpans)
        {
            foreach (TimeSpan timeSpan in timeSpans)
            {
                int lengthInDays = timeSpan.Days;

                if (lengthInDays <= 3)
                {
                    lengthOneToThree++;
                }
                else if (lengthInDays > 3 && lengthInDays <= 5)
                {
                    lengthThreeToFive++;
                }
                else if (lengthInDays > 5 && lengthInDays <= 7)
                {
                    lengthFiveToSeven++;
                }
                else if (lengthInDays > 7 && lengthInDays <= 14)
                {
                    lengthSevenToFourteen++;
                }
                else {
                    lengthFourteenPlus++;
                }
            }
        
        }

    }
}
