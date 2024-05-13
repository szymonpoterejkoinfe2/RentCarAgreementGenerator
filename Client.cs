using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentCarDocument
{
    internal class Client
    {
        public string name { set; get; }
        public string surname { set; get; }
        public string phoneNumber { set; get; }
        public string email { set; get; }


        public Client(string name, string surname, string phoneNumber, string email) 
        {    
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        // returns True if attributes pass regex tests
        public bool EvaluateAttributes()
        { 
            Regex nameSurnameRegex = new Regex(@"[A-Za-z]");
            Regex phoneNumberRegex = new Regex(@"^\d{3}-\d{3}-\d{3}$");
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (!nameSurnameRegex.IsMatch(name) && !nameSurnameRegex.IsMatch(surname))
            {
                ShowErrorBox("Błędne wartości w polu imię lub nazwisko. Proszę usunąć znaki specjalne z wprowadzonych danych!");
                return false;
            }

            if (!phoneNumberRegex.IsMatch(phoneNumber))
            {
                ShowErrorBox("Błędne wartości w polu numer telefonu. Sprawdź czy spełniaja warunki formatu ###-###-####!");
                return false;
            }

            if (!emailRegex.IsMatch(email))
            {
                ShowErrorBox("Błędne wartości w e-mail!");
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
