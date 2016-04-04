using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixCatalog;

namespace UserInput
{
    class UserMovie
    {
        View menu;
        Menu userMenu;
        public UserMovie(View menu, Menu userMenu)
        {
            this.menu = menu;
            this.userMenu = userMenu;
        }
        public Movie CreateMovie()
        {
            string newMovieTitle = userMenu.GetUserInputTitle();
            Console.WriteLine("Please enter in the rating (1-5) for the movie");
            double newMovieRating = (double)userMenu.NumbersOnlyCheck(1092, 0, 6);
            Console.WriteLine("Please enter in the length of the movie in minutes");
            int newMovieDuration = userMenu.NumbersOnlyCheck(5804, 0, 181);
            Title.GenreType newMovieGenreType = userMenu.GetGenreType();
            return new Movie(newMovieTitle, newMovieRating, newMovieGenreType, newMovieDuration);
        }
        public void PrintMovie()
        {
            int i = 1;
            foreach(Movie movie in menu.MovieList)
            {
                Console.WriteLine("{0}. {1}", i, movie.ToString());
                i++;
            }
        }
        public Movie SelectMovie()
        {
            int selectedMovie = userMenu.NumbersOnlyCheck(9846, 1, menu.MovieList.Count);
            return menu.MovieList.ElementAt(selectedMovie);
        }
    }
}
