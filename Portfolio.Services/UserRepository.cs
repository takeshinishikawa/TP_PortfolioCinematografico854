using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class UserRepository : IUserRepository
    {
        private List<User> UserRegistry { get; set; }

        public UserRepository()
        {
            UserRegistry = new List<User>();
        }

        public void AddNewUser(User newUser)
        {
            UserRegistry.Add(newUser);
        }

        public bool LookForUsername(string entryUsername)
        {
            return UserRegistry.Any(person => person.Username == entryUsername);
        }

        public bool ValidateLogin(string entryUsername, string entryPassword)
        {            
            User validUser = GetUser(entryUsername);
            if (validUser is not null)
            {
                return validUser.CheckPassword(entryPassword);
            }

            return false;
        }

        public User GetUser(string username)
        {
            return UserRegistry.SingleOrDefault(person => person.Username == username);
        }

    }
}
