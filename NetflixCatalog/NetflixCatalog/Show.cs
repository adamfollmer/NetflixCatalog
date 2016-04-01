using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Show:Title
    {
        List<Episode> episodeList;
        public Show (string name, double rating, GenreType genreType) : base (name, rating, genreType)
        {
            episodeList = new List<Episode>();
        }
        public Show()
        {

        }
        public List<Episode> EpisodeList
        {
            get { return episodeList; }
        }
        public string Name
        {
            get { return _name; }
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
                _rating = ratingHold/episodeList.Count;
            }
            get { return (double)_rating; }
        } 
        public override string ToString()
        {
            return string.Format("{0}, {1} episodes", _name, episodeList.Count);
        }
    }
}
