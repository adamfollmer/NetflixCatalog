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
        //public static Genre operator+ (Genre genreOne, Genre genreTwo) //issue with this one is we can't use titles titlelist
        //{
        //    if (genreOne.combinedGenreType.Equals(genreTwo.combinedGenreType))
        //    {
        //        return new Genre(genreOne.combinedGenreType);
        //    }
        //    int combinedGenreType = (int)genreOne.combinedGenreType + (int)genreTwo.combinedGenreType;

        //    switch (combinedGenreType)
        //    {
        //        case (3):
        //            //strip each one 

        //        case (5):
        //            return genreOne;
        //        case (6):
        //            return genreOne;
        //        case (7):
        //            return genreOne;
        //        default:
        //            return genreOne;
        //    }
        //}
        //public static Genre operator+ (Genre genre, Title title)
        //    //ISSUE: one of the parameters has to be of the class, but can't give a title to a <T> class
        //{
        //    if ((int)genre.combinedGenreType == (int)title._GenreType)
        //    {
        //        genre.AddTitles(title);
        //        return genre;
        //    }
        //    int combinedGenreType = (int)genre.combinedGenreType + (int)title._GenreType;

        //    switch (combinedGenreType)
        //    {
        //        case (3):
        //            //Add the title and each title within the genre to the new genre
        //            return title.TitleList.romaction;
        //        case (5):
        //            return title.TitleList.romcom;
        //        case (6):
        //            return title.TitleList.comaction;
        //        case (7):
        //            return title.TitleList.all;
        //        default:
        //            return title.TitleList.all;
        //    }
        //}
    }
}
