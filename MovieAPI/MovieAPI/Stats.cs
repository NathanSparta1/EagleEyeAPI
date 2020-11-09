using System;
using System.Collections.Generic;
using System.Text;

namespace EagleEye
{
    class Stats
    {
        public int MovieId { get; set; }
        public int WatchDurationMs { get; set; }

        public Stats() { }

        public Stats(int movieId, int watchDurationMs)
        {
            this.MovieId = movieId;
            this.WatchDurationMs = watchDurationMs;
        }
    }
}
