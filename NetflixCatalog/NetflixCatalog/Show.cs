using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Show:Title
    {
        List<Episode> episodeList;
        public Show()
        {
            episodeList = null;
        }
        public Show (string name, double rating, GenreType genreType) : base (name, rating, genreType)
        {
            _name = name;
            _rating = rating;
            _genreType = genreType;
            episodeList = null;
        }
        public void AddEpisode(Episode newEpisode)
        {
            episodeList.Add(newEpisode);
        }
        public double Rating
        {
            set
            {
                double ratingHold = 0;
                foreach (Episode episode in episodeList)
                {
                    ratingHold += episode.Rating;
                }
                _rating = ratingHold;
            }
        } 
        public override string ToString()
        {
            string showNameAndNumberOfEpisodes =
                _name + episodeList.Count;
            return showNameAndNumberOfEpisodes;
        }
    }
}
