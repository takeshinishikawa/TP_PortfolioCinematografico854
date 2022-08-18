using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain
{
    public class User
    {
        public string Name { get; private set; }
        public string Username { get; private set; }
        public DateTime BirthDate { get; private set; }
        private string Password { get; set; }


        public User(string name, string username, DateTime birthDate, string password)
        {
            this.Name = name;
            this.Username = username;
            this.BirthDate = birthDate;
            this.Password = password;
        }

        void ChangePassword(string password)
        {
            this.Password = password;
        }

        void ChangeName(string name)
        {
            this.Name = name;
        }

        bool CheckPassword(string userInput)
        {
            return this.Password.Equals(userInput);
        }
    }
}
