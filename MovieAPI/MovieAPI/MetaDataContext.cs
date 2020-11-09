using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace EagleEye
{
    class MetaDataContext : Context
    {
        public static List<MovieInfo> ReadMetaData(string input)
        {
            try
            {
                var movies = new List<MovieInfo>();

                using (TextFieldParser parser = new TextFieldParser(input, Encoding.Unicode))
                {
                    var headers = parser.ReadLine();

                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        //Process row
                        string[] fields = parser.ReadFields();

                        movies.Add(new MovieInfo(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]), fields[2], fields[3], fields[4], Convert.ToInt32(fields[5])));
                    }
                }
                return movies;
            }
            catch (FormatException)
            {
                throw new FormatException("Error with Input string");
            }
        }

        public static void ExportMovies(string input, string output)
        {
            var movieList = ReadMetaData(input);

            SearchFilter filter = new SearchFilter();
            var filteredMovies = filter.Filter(movieList);

            WriteMovies(filteredMovies, output);

        }

    }
}
