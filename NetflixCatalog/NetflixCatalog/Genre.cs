using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Genre : IEnumerable
    {
        public List<Title> titleList;
        CombinedGenreType combinedGenre;
        public enum CombinedGenreType
        {
            Null = 0,
            Romance = 1,
            Action = 2 ,
            Romaction = 3,
            Comedy = 4,
            RomCom = 5,
            ComAction = 6,
            All = 7
        }
        public Genre(CombinedGenreType genreType)
        {
            titleList = new List<Title>();
            combinedGenre = genreType;
        }
        public CombinedGenreType CombinedGenre
        {
            get { return combinedGenre; }
        }
        public void AddTitles(Title titleToAdd)
        {
            titleList.Add(titleToAdd);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Title title in titleList)
            {
                yield return title;
            }
        }
        public static Genre operator+ (Genre genreOne, Genre genreTwo)
        {
            int genreHold;
            if (genreOne.combinedGenre == genreTwo.combinedGenre)
            {
                genreHold = (int)genreOne.combinedGenre;
            }
            else
            {
                genreHold = (int)genreOne.combinedGenre + (int)genreTwo.combinedGenre;
            }
            return new Genre((Genre.CombinedGenreType)genreHold);
        }
        public static Genre operator+ (Genre genre, Title title)
        {
            int genreHold;
            if ((int)genre.combinedGenre == (int)title._GenreType)
            {
                genreHold = (int)genre.combinedGenre;
            }
            else
            {
                genreHold = (int)genre.combinedGenre + (int)title._GenreType;
            }
            return new Genre((Genre.CombinedGenreType)genreHold);
        }
    }
}
