using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    abstract class Title
    {
        protected string _name;
        protected double? _rating;
        protected GenreType? _genreType;
        [Flags]
        public enum GenreType
        {
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
        //public static GenreType operator +(Title titleOne, Title titleTwo)
        //{
        //    if (titleOne.genreType == titleTwo.genreType)
        //    {
        //        return titleOne.genreType;
        //    }
        //    int combinedGenreType = (int)titleOne.genreType + (int)titleTwo.genreType;
        //    switch (combinedGenreType)
        //    {
        //        case ()
        //    }

        //}
    }
}
