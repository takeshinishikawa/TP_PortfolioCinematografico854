using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public static class InitDB
    {
        public static void NewUsers(IUserRepository userRepository)
        {
            User newUser1 = new("Luiza Campello", "luizacampello", DateTime.Parse("19/04/1996"), "123");
            userRepository.AddNewUser(newUser1);

            User newUser2 = new("Severo Snape", "halfBloodPrince", DateTime.Parse("09/01/1960"), "123");
            userRepository.AddNewUser(newUser2);

        }
    }
}
