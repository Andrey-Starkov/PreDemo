using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemo.Class
{
    public class Client
    {
        public int ID;
        public string Name;
        public string Surname;
        public string Middlename;
        public string BirtDay;
        public string RegDay;
        public string Email;
        public string Phone;
        public string Gender;
        public string Photo;

        public Client(int Id,string name,string surname,string middlename,string birthday,string regday,string email,string phone,string gender,string photo)
        {
            ID = Id;
            Name = name;
            Surname = surname;
            Middlename = middlename;
            BirtDay = birthday;
            RegDay = regday;
            Email = email;
            Phone = phone;
            Gender = gender;
            Photo = photo;
        }


    }
}
