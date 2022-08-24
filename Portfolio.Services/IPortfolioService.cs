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
        public void AddScoreToPortfolio(User loggedUser, Score newScore);
       
        public int CountWatchedMovies(User loggedUser);


        public (Category category, int count) FindMostWatchedCategory(User loggedUser);

        public List<Score> LastNReviews(User loggedUser, int num);
        
    }
}
