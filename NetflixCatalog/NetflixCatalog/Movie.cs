using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Movie:Title
    {
        int? duration;
        public Movie(string name, double rating, GenreType genreType, int duration) 
            : base (name, rating, genreType)
        {
            this.duration = duration;
        }
        public Movie()
        {

        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} minutes", _name, duration);
        }
    }
}
