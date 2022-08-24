using Portfolio.Domain;
using Portfolio.Domain.Enum;
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
            Dictionary<Category, int> categories = new Dictionary<Category, int>();
            foreach (Score score in loggedUser.Portfolio)
            {
                Category currentCategory = score.Movie.Category;

                if (categories.ContainsKey(currentCategory))
                {
                    categories[currentCategory]++;
                }
                else
                {
                    categories[currentCategory] = 1;
                }
            }
        }

        private void MostWatchedCategory(Dictionary<Category, int> categoriesCount)
        {
            
            foreach (KeyValuePair<Category, int> item in categoriesCount)
            {

            }


        }

    }
}
