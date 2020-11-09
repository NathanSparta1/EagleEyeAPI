using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace EagleEye
{
    class StatsContext : Context
    {
        /*
        public static IEnumerable<Stats> ReadStats(string input)
        {
            try
            {
                var stats = new List<Stats>();

                using (TextFieldParser parser = new TextFieldParser(input, Encoding.ASCII))
                {
                    var headers = parser.ReadLine();

                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        //Process row
                        string[] fields = parser.ReadFields();

                        stats.Add(new Stats(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1])));
                    }
                }

                return stats;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Error in input string");
            }
        }*/
        /*
        public static List<MovieStats> Refactor(IEnumerable<Stats> stats, IEnumerable<MovieInfo> movieInfo)
        {
            var movieStats = new List<MovieStats>();

            
            int averageDuration = 0;
            int watches = 0;





            
                foreach (var movie in movieInfo)
                {
                foreach (var stat in stats)
                {

                    {

                        if (stat.MovieId == movie.MovieId)
                        {
                            movieStats.Add(new MovieStats(movie.MovieId, movie.Title, stat.WatchDurationMs / 1000,
                                watches, movie.ReleaseYear));

                        }

                    }
                }
                }
            return movieStats;
        }

       
       

        public static void ExportMovies(string input,string mdInput, string output)
        {
            var movieList = ReadStats(input);
            var refactor = Refactor(movieList, MetaDataContext.ReadMetaData(mdInput));
            WriteMovies(refactor, output);

        }
*/
    }
}
