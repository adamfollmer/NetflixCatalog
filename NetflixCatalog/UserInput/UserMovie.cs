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
            return new Movie();
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
