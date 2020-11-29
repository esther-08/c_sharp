using System;
using System.Collections.Generic;
using System.Text;

namespace giraffegetters
{
    class Movies
    {
        public string title;
        public string director;
        private string rating;

        public Movies(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if(value == "G" || value== "PG" || value == "PG-13" || value == "PG-18")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }

        }
    }
}
