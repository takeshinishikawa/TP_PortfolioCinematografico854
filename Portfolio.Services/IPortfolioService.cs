using Portfolio.Domain.Enum;
using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public interface IPortfolioService
    {
        public void AddReviewToPortfolio(User loggedUser, Review newScore);
       
        public int CountWatchedMovies(User loggedUser);

        public (string category, int count) FindMostWatchedCategory(User loggedUser);

        public List<Review> LastNReviews(User loggedUser, int num);
        
    }
}
