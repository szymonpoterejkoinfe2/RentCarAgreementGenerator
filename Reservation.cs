using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarDocument
{
    internal class Reservation
    {
        public int reservationNumber { set; get; }
        public DateTime pickUpDate { set; get; }
        public DateTime returnDate { set; get; }
        public decimal price { set; get; } = 0;

        public Reservation(int number, DateTime pickDate, DateTime returnDate, decimal price) {
            
            reservationNumber = number;
            pickUpDate = pickDate;
            this.returnDate = returnDate;
            this.price = price;
        }

        public int GetReservationPeriodinDays()
        {

            if (returnDate >= pickUpDate)
            {
                TimeSpan reservationTimeSpam = returnDate - pickUpDate;

                if (reservationTimeSpam.Days == 0)
                {
                    return 1;
                }
                else return reservationTimeSpam.Days;
            }
            return 0;
        }
        public TimeSpan GetReservationTimeSpan()
        {
            if (returnDate >= pickUpDate)
            {
                TimeSpan reservationTimeSpam = returnDate - pickUpDate;
                return reservationTimeSpam;
            }
            return TimeSpan.Zero;
        }

        public bool EvaluateAttributes()
        {
            if (reservationNumber < 0)
            {
                ShowErrorBox("Numer rezerwacji nie może być mniejszy od 0!");
                return false;
            }

            if (pickUpDate > returnDate)
            {
                ShowErrorBox("Data zwrotu nie może być wcześniejsza niż data wydania pojazdu!");
                return false; 
            }

            if (price < 0)
            {
                ShowErrorBox("Wartość zamówienia nie może być ujemna!");
                return false; 
            }

            return true;
        }

        private void ShowErrorBox(string errorText)
        {
            MessageBox.Show($"{errorText}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
