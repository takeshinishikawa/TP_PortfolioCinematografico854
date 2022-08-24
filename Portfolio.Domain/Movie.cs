using Portfolio.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Portfolio.Domain
{
    public class Movie
    {
        public string Title { get; private set; }
        public ushort ReleaseYear { get; private set; } //1888 até ano atual
        public Category Category { get; private set; }
        public Studio Studio { get; private set; }

        public Movie(string title, ushort releaseYear, Category category, Studio studio)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Category = category;
            Studio = studio;
        }

        void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }

        bool ChangeReleaseYear(ushort newReleaseYear)
        {
            if (newReleaseYear >= 1888 && newReleaseYear <= DateTime.Now.Year)
            {
                ReleaseYear = newReleaseYear;
                return true;
            }
            else
                return false;
        }

        void ChangeCategory(Category newCategory)
        {
            Category = newCategory;
        }

        void ChangeStudio(Studio newStudio)
        {
            Studio = newStudio;
        }

        public override string ToString()
        {
            string movieString = $"Title: {Title}" +
                $"Release Year: {ReleaseYear}" +
                $"Category: {Category}" +
                $"Studio: {Studio}";

            return movieString;
        }
    }
}
