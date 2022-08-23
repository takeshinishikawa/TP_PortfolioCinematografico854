using Portfolio.Domain.Enum;
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
        public Star Value { get; private set; }
        public string Comments { get; set; }

        public Score(Movie movie, Star stars)
        {
            Movie = movie;
            Value = stars;
            Comments = "";
        }

        public Score(Movie movie, Star stars, string comments)
        {
            Movie = movie;
            Value = stars;
            Comments = comments;
        }

        void ChangeScore(Star newValue)
        {
            Value = newValue;
        }

        void ChangeComments(string newComments)
        {
            Comments = newComments;
        }
    }
}