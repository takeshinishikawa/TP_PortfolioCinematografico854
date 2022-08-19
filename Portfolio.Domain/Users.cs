using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain
{
    public static class Users
    {
        public static List<User> UserList = new List<User>()
        {
            new User("Admin", "admin", DateTime.Parse("13/06/1989"), "Batatinha123")
        };
    }
}