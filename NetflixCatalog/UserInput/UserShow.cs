using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixCatalog;

namespace UserInput
{
    class UserShow
    {
        View menu;
        Menu userMenu;
        public UserShow(View menu, Menu userMenu)
        {
            this.menu = menu;
            this.userMenu = userMenu;
        }
        public Show CreateShow()
        {
            string newShowTitle = userMenu.GetUserInputTitle();
            Console.WriteLine("Please enter in the rating (1-5) for the movie");
            double newShowRating = (double)userMenu.NumbersOnlyCheck(1092, 0, 6);
            Console.WriteLine("Please enter in the length of the movie in minutes");
            Title.GenreType newMovieGenreType = userMenu.GetGenreType();
            return new Show(newShowTitle, newShowRating, newMovieGenreType);
        }
        public void PrintShow()
        {
            int i = 1;
            foreach(Show show in menu.ShowList)
            {
                Console.WriteLine("{0}. {1}", i, show.ToString());
                i++;
            }
        }
        public void PrintShowAndEpisode()
        {
            int i = 1;
            foreach(Show show in menu.ShowList)
            {
                show.Rating = show.Rating;
                Console.WriteLine("{0}. {1}", i, show.ToString());
                Console.WriteLine("Rating: {0}", show.Rating.ToString("#.00"));
                foreach(Episode episode in show.EpisodeList)
                {
                    Console.WriteLine("Episode Name: {0}, Rating: {1}", episode.Name, episode.Rating);
                }
                i++;
            }
        }
        public Show SelectShow()
        {
            int selectedShow = userMenu.NumbersOnlyCheck(5654, 1, menu.ShowList.Count)-1;
            return menu.ShowList.ElementAt(selectedShow);
        }
        public Episode CreateEpisode()
        {
            Console.WriteLine("Enter in the episode name");
            string episodeName = Console.ReadLine();
            Console.WriteLine("Enter in a rating, 1-5");
            int rating = userMenu.NumbersOnlyCheck(56865, 1, 5);
            return new Episode(rating, episodeName);
        }
    }
}
