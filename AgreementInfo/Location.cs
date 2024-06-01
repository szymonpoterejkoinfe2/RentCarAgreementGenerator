using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentCarDocument
{
    internal class Location : Info
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

        public override bool EvaluateAttributes()
        {
            Regex regexCity = new Regex(@"[A-Za-z]");
            Regex regexStreet = new Regex(@"[A-Za-z0-9]");
            Regex regexPostalCode = new Regex(@"^\d{2}-\d{3}$");

            if (!regexCity.IsMatch(city))
            {
                ShowErrorBox("Błędne wartości w polu miasto. Proszę usunąć znaki specjalne z wprowadzonych danych!");
                return false;
            }

            if (!regexStreet.IsMatch(street))
            {
                ShowErrorBox("Błędne wartości w polu ulica. Proszę usunąć znaki specjalne z wprowadzonych danych!");
                return false;
            }

            if (!regexPostalCode.IsMatch(postalCode))
            {
                ShowErrorBox("Błędne wartości w polu kod pocztowy. Proszę sprawdzić czy spełnia warunki wzoru ##-###!");
                return false;
            }

            return true;
        }

    }
}
