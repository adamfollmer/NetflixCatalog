using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    abstract class Title
    {
        TemporaryTitleList titleList = new TemporaryTitleList();
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
        public static Genre<Title> operator+ (Title titleOne, Title titleTwo)
        {
            if (titleOne._genreType == titleTwo._genreType)
            {
                int genreHold = (int)titleOne._genreType;
                string enumString = Enum.GetName(typeof(Genre<Title>.CombinedGenreType), genreHold);
                Genre<Title>.CombinedGenreType enumName = 
                    (Genre<Title>.CombinedGenreType)Enum.Parse(typeof(Genre<Title>.CombinedGenreType), enumString);
                return new Genre<Title>(enumName);
            } 

            int combinedGenreType = (int)titleOne._genreType + (int)titleTwo._genreType;
            switch (combinedGenreType)
            {
                case (3):
                    titleOne.titleList.romaction.AddTitles(titleOne);
                    titleOne.titleList.romaction.AddTitles(titleTwo);
                    return titleOne.titleList.romaction;
                case (5):
                    titleOne.titleList.romcom.AddTitles(titleOne);
                    titleOne.titleList.romcom.AddTitles(titleTwo);
                    return titleOne.titleList.romcom;
                case (6):
                    titleOne.titleList.comaction.AddTitles(titleOne);
                    titleOne.titleList.comaction.AddTitles(titleTwo);
                    return titleOne.titleList.comaction;
                default:
                    titleOne.titleList.all.AddTitles(titleOne);
                    titleOne.titleList.all.AddTitles(titleTwo);
                    return titleOne.titleList.all;
            }

        }
    }
}
