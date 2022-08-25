using Portfolio.Domain;
using Portfolio.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public interface IMovieRepository
    {
        public void AddMovie(Movie movie);
        public List<Movie> SearchMovieByTitle(string movieName);
        public List<Movie> SearchMovieByReleaseYear(ushort releaseYear);
        public List<Movie> SearchMovieByCategory(Category category);
        public List<Movie> SearchMovieByStudio(Studio studio);
        public Movie GetMovie(string title);
        public int Count();

        public List<Movie> GetMovieList();
    }
}
