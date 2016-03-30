﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Movie:Title
    {
        int? duration;
        public Movie() 
        {
            duration = null;
        }
        public Movie(string name, double rating, GenreType genreType, int duration) : base (name, rating, genreType)
        {
            _name = name;
            _rating = rating;
            _genreType = genreType;
            this.duration = duration;
        }

        public override string ToString()
        {
            string showNameAndNumberOfEpisodes =
              "{0}, {duration} minutes", _name, duration;
            return showNameAndNumberOfEpisodes;
        }
    }
}