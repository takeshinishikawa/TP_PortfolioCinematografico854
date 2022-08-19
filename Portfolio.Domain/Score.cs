using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain
{
    public class Score
    {
        public Movie Movie { get; private set; }
        public Star Score { get; private set; }
        public string Comments { get; set; }//Deixar sem o private para não exigir passar pelo construtor, logo, pode ser deixada em branco.

        public Score(Movie movie, Star stars, string Comments)
        {
            Movie = movie;
            Score = stars;
            Comments = Comments;
        }

        void ChangeScore(Star newStars)
        {
            Score = newStars;
        }

        void ChangeComments(string newComments)
        {
            Comments = newComments;
        }
    }
}