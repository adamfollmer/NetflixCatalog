using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class View
    {
        TemporaryTitleList library = new TemporaryTitleList();
        List<Movie> movieList = new List<Movie>();
        List<Show> showList = new List<Show>();
        List<Title> masterTitleList = new List<Title>();
        List<Genre> genreList = new List<Genre>();
        Genre genre = new Genre(Genre.CombinedGenreType.All);
        public List<Show> ShowList
        {
            get
            {
                return showList;
            }
        }
        public List<Movie> MovieList
        {
            get
            {
                return movieList;
            }
        }
        public List<Title> MasterTitleList
        {
            get
            {
                return masterTitleList;
            }
        }
        public List<Genre> GenreList
        {
            get
            {
                return genreList;
            }
        }
        public void AddMovieToMovieList(Movie movie)
        {
            movieList.Add(movie);
            masterTitleList.Add(movie);
        }
        public void AddShowtoShowList(Show show)
        {
            showList.Add(show);
            masterTitleList.Add(show);
        }
        public void PrintGenre (Genre genre)
        {
            foreach (Title title in genre)
            {
                Console.WriteLine(title.ToString());
            }
        }
        public void AddGenreToGenreList(Genre genre)
        {
            genreList.Add(genre);
        }
    }
}
