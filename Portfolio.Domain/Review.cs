using Portfolio.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain
{
    public class Review
    {
        public Movie Movie { get; private set; }
        public Star Value { get; private set; }
        public string Comments { get; set; }

        public Review(Movie movie, Star value)
        {
            Movie = movie;
            Value = value;
            Comments = "";
        }

        public Review(Movie movie, Star value, string comments)
        {
            Movie = movie;
            Value = value;
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