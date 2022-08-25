using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public interface IUserRepository
    {
        public void AddNewUser(User newUser);

        public void DeleteUser(User newUser);

        public bool LookForUsername(string entryUsername);

        public bool ValidateLogin(string entryUsername, string entryPassword);

        public User GetUser(string username);

    }
}
