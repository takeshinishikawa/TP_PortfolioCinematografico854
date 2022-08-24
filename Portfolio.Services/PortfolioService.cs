using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class PortfolioService : IPortfolioService
    {        
        public void AddScoreToPortfolio(User loggedUser, Score newScore)
        {
            loggedUser.Portfolio.Add(newScore);
        }

        public int CountTotalMovies(User loggedUser)
        {
            return loggedUser.Portfolio.Count;
        }

        private void MoviesByCategory(User loggedUser)
        {

        }

    }
}
