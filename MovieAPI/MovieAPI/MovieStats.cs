using System;
using System.Collections.Generic;
using System.Text;

namespace EagleEye
{

    public class MovieStats : Movie
    {
        public int AverageWatchDurationS { get; set; }
        public int Watches { get; set; }


        public MovieStats()
        { }
        public MovieStats(int movieId, string title, int averageWatchDurationS, int watches, int releaseYear)
        {
            this.MovieId = movieId;
            this.Title = title;
            this.AverageWatchDurationS = averageWatchDurationS;
            this.Watches = watches;
            this.ReleaseYear = releaseYear;


        }
    }

}

