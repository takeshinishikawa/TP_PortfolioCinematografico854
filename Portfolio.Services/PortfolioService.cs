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

        public int CountWatchedMovies(User loggedUser)
        {
            return loggedUser.Portfolio.Count;
        }

        private Dictionary<Category, int> MoviesByCategory(User loggedUser)
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

            return categories;
        }

        public (Category category, int count) FindMostWatchedCategory(User loggedUser)
        {
            Dictionary<Category, int> categoriesCount = MoviesByCategory(loggedUser);

            KeyValuePair<Category, int> mostWatchedCategory = categoriesCount.First();
            foreach (KeyValuePair<Category, int> item in categoriesCount)
            {
                if (item.Value > item.Value)
                {
                    mostWatchedCategory = item;
                }
            }

            return (mostWatchedCategory.Key, mostWatchedCategory.Value);
        }

        public List<Score> LastNReviews(User loggedUser, int num)
        {
            List<Score> review = new(loggedUser.Portfolio);

            if (review.Count >= num)
            {
                review = review.TakeLast(num).ToList();
            }

            review.Reverse();

            return review;            
        }
    }
}
