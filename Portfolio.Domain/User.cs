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
        public List<Score> Portfolio { get; set; }

        public User(string name, string username, DateTime birthDate, string password)
        {
            Name = name;
            Username = username;
            BirthDate = birthDate;
            Password = password;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public bool CheckPassword(string userInput)
        {
            return Password.Equals(userInput);
        }
    }
}
