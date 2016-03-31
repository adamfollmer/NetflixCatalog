using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Genre<T> : IEnumerable<T>
    {
        public List<T> titleList;
        CombinedGenreType combinedGenreType;
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
            titleList = new List<T>();
            combinedGenreType = genreType;
        }
        public void AddTitles(T titleToAdd)
        {
            titleList.Add(titleToAdd);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T title in titleList)
            {
                yield return title;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()//fuck this guy
        {
            throw new NotImplementedException();
        }
        public static Genre<T> operator +(Genre<T> genreOne, Genre<T> genreTwo)
        {
            if (genreOne.combinedGenreType.Equals(genreTwo.combinedGenreType))
            {
                return new Genre<T>(genreOne.combinedGenreType);
            }
            int combinedGenreType = (int)genreOne.combinedGenreType + (int)genreTwo.combinedGenreType;


        }
    }
}
