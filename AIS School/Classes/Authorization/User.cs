using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_School.Classes.Authorization
{
    public class User
    {
        public User(uint ID, string Login, string Password, string Surname, string FirstName, string SecondName, string Email, string Phone, string Role, DateTime DateBirth)
        {
            this.ID = ID;
            this.Login = Login;
            this.Password = Password;
            this.Surname = Surname;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Email = Email;
            this.Phone = Phone;
            this.Role = Role;
            this.DateBirth = DateBirth;
        }
        public uint ID;
        public string Login;
        public string Password;
        public string Surname;
        public string FirstName;
        public string SecondName;
        public string Email;
        public string Phone;
        public string Role;
        public DateTime DateBirth;
    }

}
