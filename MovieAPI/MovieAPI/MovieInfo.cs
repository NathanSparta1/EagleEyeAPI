using System;
using System.Collections.Generic;
using System.Text;

namespace EagleEye
{
    class MovieInfo : Movie
    {
        public int? EntryId { get; set; }
        public string Language { get; set; }
        public string Duration { get; set; }

        public MovieInfo() { }
        public MovieInfo(int? entryId, int movieId, string title, string duration, string language, int releaseYear)
        {
            this.EntryId = entryId;
            this.MovieId = movieId;
            this.Title = title;
            this.Duration = duration;
            this.Language = language;
            this.ReleaseYear = releaseYear;

        }
    }
}

