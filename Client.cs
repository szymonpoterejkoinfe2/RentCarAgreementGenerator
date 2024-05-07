using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
