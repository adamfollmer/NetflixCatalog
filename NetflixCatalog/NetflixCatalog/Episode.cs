using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Episode
    {
        double rating;
        string name;

        public Episode(double rating, string name)
        {
            this.rating = rating;
            this.name = name;
        }
        public double Rating
        {
            get;
        }
    }
}
