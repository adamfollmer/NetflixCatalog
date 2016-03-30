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

        public Genre(T movieOrShow)
        {
            titleList = new List<T>();
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T title in titleList)
            {
                yield return title;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
