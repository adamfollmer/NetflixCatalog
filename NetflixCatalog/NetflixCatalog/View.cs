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
        public void AddPremadeGenresToGenreList()
        {
            genreList.Add(library.action);
            genreList.Add(library.all);
            genreList.Add(library.comaction);
            genreList.Add(library.comedy);
            genreList.Add(library.romaction);
            genreList.Add(library.romance);
            genreList.Add(library.romcom);
        }
        public void AddPremadeTitlesToLists()
        {
            library.AddShows();
            library.AddShowsToGenre();
            foreach (Genre genre in genreList)
            {
                foreach (Title title in genre)
                {
                    masterTitleList.Add(title);
                    if (title.GetType() == typeof(Movie))
                    {
                        movieList.Add((Movie)title);
                    }
                    else
                    {
                        showList.Add((Show)title);
                    }
                }
            }
        }
        public void AddMovieToMovieList(Movie movie)
        {
            if (!movieList.Contains(movie))
            {
                movieList.Add(movie);
                masterTitleList.Add(movie);
                AddTitleToGenre(movie);
                Console.WriteLine("{0} added to {1} genre", movie.Name, movie._GenreType);
            }
            else
            {
                Console.WriteLine("{0} already exists in {0} genre", movie.Name, movie._GenreType);
            }

        }
        public void AddShowtoShowList(Show show)
        {
            if (!showList.Contains(show))
            {
                showList.Add(show);
                masterTitleList.Add(show);
                AddTitleToGenre(show);
                Console.WriteLine("{0} added to {1} genre", show.Name, show._GenreType);
            }
            else
            {
                Console.WriteLine("{0} already exists in {0} genre", show.Name, show._GenreType);
            }

        }
        public void PrintGenre(Genre genre)
        {
            Console.WriteLine("Viewing results for {0}", genre.CombinedGenre);
            foreach (Genre genreInList in genreList)
            {
                if (genre.CombinedGenre == genreInList.CombinedGenre)
                {
                    foreach (Title title in genreInList)
                    {
                        Console.WriteLine(title.ToString());
                    }
                }
            }

        }
        public void AddTitleToGenre(Title title)
        {
            foreach (Genre genre in genreList)
            {
                if ((int)title._GenreType == (int)genre.CombinedGenre)
                {
                    genre.AddTitles(title);
                }
            }
        }
        public void AddTitlesToAggregatedGenre(Title title1, Title title2)
        {
            foreach (Genre allGenre in GenreList)
            {
                if (allGenre.CombinedGenre == (title1 + title2).CombinedGenre)
                {
                    allGenre.AddTitles(title1);
                    allGenre.AddTitles(title2);
                    break;
                }
            }
        }
        public void AddTitlesToAggregatedGenre(Genre genre1, Genre genre2)
        {
            foreach (Genre allGenre in GenreList)
            {
                if (allGenre.CombinedGenre == (genre1 + genre2).CombinedGenre)
                {
                    foreach (Title title in genre1)
                    {
                        allGenre.AddTitles(title);
                    }
                }
            }
            foreach (Genre allGenre in GenreList)
            {
                if (allGenre.CombinedGenre == (genre1 + genre2).CombinedGenre)
                {
                    foreach (Title title in genre2)
                    {
                        allGenre.AddTitles(title);
                    }
                }
            }
        }

        public void AddTitlesToAggregatedGenre(Title title, Genre genre)
        {
            foreach (Genre allGenre in GenreList)
            {
                if (allGenre.CombinedGenre == (genre + title).CombinedGenre)
                {
                    foreach (Title genreTitle in genre)
                    {
                        allGenre.AddTitles(genreTitle);
                    }
                    allGenre.AddTitles(title);
                    break;
                }

            }
        }
    }
}
