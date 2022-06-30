using System;
namespace get_set_example
{
    public class Movie
    {
        public enum RatingTypes { G, PG, M, MA, R }

        // Private Fields
        private long _length;
        private string _title;
        private RatingTypes _ratingType;
        private long _releaseDate;
        private long _watchDate = 0 ; // The most recent time I've watched the movie
        private long _watchCount = 0; // No. of times I've watched the movie 


        // Public Properties
        public string Title { get { return _title; } }
        public string Info { get { return $"{_title}, ({_releaseDate}) - {_ratingType}, {_length} mins"; } }

        // Will count how many times watchCount has been changed
        public long MostRecentWatchDate { get { return _watchDate; } set { _watchDate = value; _watchCount++; } }
        public long WatchCount { get { return _watchCount; } }


        public Movie (string title, long length, RatingTypes rating, long releaseDate)
        {
            _title = title;
            _length = length;
            _ratingType = rating;
            _releaseDate = releaseDate;
        }

    }
}
