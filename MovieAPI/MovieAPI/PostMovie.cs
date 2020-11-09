using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace EagleEye
{
    class PostMovie
    {

        public void CreateMovie(string input)
        {
            MovieInfo newMovie = new MovieInfo();


            newMovie.EntryId = File.ReadAllLines(input).Length + 2;

            Console.WriteLine("Define Movie Id");
            string id = Console.ReadLine();
            while (Regex.IsMatch(id, @"^\d+$") == false)
            {
                Console.WriteLine("Id must be a number");
                id = Console.ReadLine();

            }
            newMovie.MovieId = Convert.ToInt32(id);

            Console.WriteLine("Name of the Movie");
            newMovie.Title = Console.ReadLine();

            Console.WriteLine("language of the movie");
            newMovie.Language = Console.ReadLine();

            Console.WriteLine("Duration of the movie");
            newMovie.Duration = Console.ReadLine();

            Console.WriteLine("Release year of the movie");
            string releaseYear = Console.ReadLine();
            while (Regex.IsMatch(releaseYear, @"^\d+$") == false)
            {
                Console.WriteLine("Release year must be a number");
                releaseYear = Console.ReadLine();

            }
            newMovie.ReleaseYear = Convert.ToInt32(releaseYear);

            var csv = new StringBuilder();
            var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}", newMovie.EntryId, newMovie.MovieId,
                newMovie.Title, newMovie.Language, newMovie.Duration, newMovie.ReleaseYear, Environment.NewLine);
            csv.Append(newLine);

            if (File.Exists(input))
            {
                File.AppendAllText(input, csv.ToString());

            }
            Console.WriteLine("New movie added");

        }
    }
}
