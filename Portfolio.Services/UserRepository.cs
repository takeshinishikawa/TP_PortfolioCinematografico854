using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class UserRepository
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

        public bool IsValidPassword(string username, string entryPassword)
        {
            User user = UserRegistry.Single(person => person.Username == username);
            return user.CheckPassword(entryPassword);
        }

    }
}
