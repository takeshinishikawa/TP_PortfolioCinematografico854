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
        public void AddReviewToPortfolio(User loggedUser, Review newReview)
        {
            bool reviewedMovie = false;
            int movieIndex = -1;
            List<Review> portfolio = loggedUser.Portfolio;
            Movie newMovieReview = newReview.Movie;

            for (int i = 0; i < portfolio.Count; i++)
            {
                if (portfolio[i].Movie == newMovieReview)
                {
                    reviewedMovie = true;
                    movieIndex = i;
                    break;
                }
            }

            if (reviewedMovie)
            {
                loggedUser.Portfolio.RemoveAt(movieIndex);
            }
            
            loggedUser.Portfolio.Add(newReview);                   
            
        }

        public int CountWatchedMovies(User loggedUser)
        {
            return loggedUser.Portfolio.Count;
        }

        private Dictionary<Category, int> MoviesByCategory(User loggedUser)
        {
            Dictionary<Category, int> categories = new Dictionary<Category, int>();

            foreach (Review score in loggedUser.Portfolio)
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

        public (string category, int count) FindMostWatchedCategory(User loggedUser)
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
            string favoriteCategory = Extensions.GetEnumDescription(mostWatchedCategory.Key);
            return (favoriteCategory, mostWatchedCategory.Value);
        }

        public List<Review> LastNReviews(User loggedUser, int num)
        {
            List<Review> review = new(loggedUser.Portfolio);

            if (review.Count >= num)
            {
                review = review.TakeLast(num).ToList();
            }

            review.Reverse();

            return review;            
        }
    }
}
