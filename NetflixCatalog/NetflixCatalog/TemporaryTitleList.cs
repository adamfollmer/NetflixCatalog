using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class TemporaryTitleList
    {
        //movies
        public Movie dieHard = new Movie("Die Hard", 2, Title.GenreType.Action, 120);
        public Movie dieHard2 = new Movie("Die Hard 2", 3, Title.GenreType.Action, 120);
        public Movie officeSpace = new Movie("Office Space", 5, Title.GenreType.Comedy, 90);
        public Movie notebook = new Movie("The Notebook", 3, Title.GenreType.Romance, 400);

        //shows
        public Show theOffice = new Show("The Office", 5, Title.GenreType.Comedy);
        public Show greys = new Show("Grey's Anatomy", 1, Title.GenreType.Romance);
        public Show daredevil = new Show("Daredevil", 5, Title.GenreType.Action);

        //episodes
        public Episode office1 = new Episode(4, "Epi One");
        public Episode office2 = new Episode(3, "Epi Two");
        public Episode office3 = new Episode(5, "Epi Three");

        public Episode grey1 = new Episode(1, "Epi One");
        public Episode grey2 = new Episode(1, "Epi Two");
        public Episode grey3 = new Episode(2, "Epi Three");

        public Episode dare1 = new Episode(2, "Epi One");
        public Episode dare2 = new Episode(3, "Epi Two");
        public Episode dare3 = new Episode(5, "Epi Three");
        public TemporaryTitleList()
        {
        }
        //adding episodes to shows
        public void AddShows()
        {
            theOffice.AddEpisode(office1);
            theOffice.AddEpisode(office2);
            theOffice.AddEpisode(office3);
            greys.AddEpisode(grey1);
            greys.AddEpisode(grey2);
            greys.AddEpisode(grey3);
            daredevil.AddEpisode(dare1);
            daredevil.AddEpisode(dare2);
            daredevil.AddEpisode(dare3);
        }


    }
}
