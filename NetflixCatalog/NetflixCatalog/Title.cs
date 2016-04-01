using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public abstract class Title
    {
        protected string _name;
        protected double? _rating;
        protected GenreType? _genreType;
        [Flags]
        public enum GenreType
        {
            Null = 0,
            Romance = 1,
            Action = 2,
            Comedy = 4,
            All = 7
        }
        public Title()
        {
            _name = null;
            _rating = null;
            _genreType = null;
        }
        public Title(string name, double rating, GenreType genreType)
        {
            _name = name;
            _rating = rating;
            _genreType = genreType;
        }
        public GenreType _GenreType
        {
            get { return (GenreType)_genreType; }
        } 
        public string _Name
        {
            get { return _name; }
        }
        public static Genre operator+ (Title titleOne, Title titleTwo)
        {
            int genreHold;
            if (titleOne._genreType == titleTwo._genreType)
            {
                genreHold = (int)titleOne._genreType;
            } else
            {
                genreHold = (int)titleOne._genreType + (int)titleTwo._genreType;
            }
            return new Genre((Genre.CombinedGenreType)genreHold);
        }
        //public static Genre operator+ (Title titleOne, Title titleTwo)
        //{
        //    if (titleOne._genreType == titleTwo._genreType)
        //    {
        //        int genreHold = (int)titleOne._genreType;
        //        string enumString = Enum.GetName(typeof(Genre.CombinedGenreType), genreHold);
        //        Genre.CombinedGenreType enumName = 
        //            (Genre.CombinedGenreType)Enum.Parse(typeof(Genre.CombinedGenreType), enumString);
        //        return new Genre(enumName);
        //    } 

        //    int combinedGenreType = (int)titleOne._genreType + (int)titleTwo._genreType;
        //    switch (combinedGenreType)
        //    {
        //        case (3):
        //            titleOne._titleList.romaction.AddTitles(titleOne);
        //            titleOne._titleList.romaction.AddTitles(titleTwo);
        //            return titleOne._titleList.romaction;
        //        case (5):
        //            titleOne._titleList.romcom.AddTitles(titleOne);
        //            titleOne._titleList.romcom.AddTitles(titleTwo);
        //            return titleOne._titleList.romcom;
        //        case (6):
        //            titleOne._titleList.comaction.AddTitles(titleOne);
        //            titleOne._titleList.comaction.AddTitles(titleTwo);
        //            return titleOne._titleList.comaction;
        //        default:
        //            titleOne._titleList.all.AddTitles(titleOne);
        //            titleOne._titleList.all.AddTitles(titleTwo);
        //            return titleOne._titleList.all;
        //    }

        //}
    }
}
