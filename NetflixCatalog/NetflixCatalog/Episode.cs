using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Episode
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
            get { return rating; }
        }
        public string Name
        {
            get { return name; }
        }
    }
}
