using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EagleEye
{
    class SearchFilter
    {

        public List<MovieInfo> SearchMovieInfo(List<MovieInfo> movies, int movieId)
        {
            List<MovieInfo> FilteredMovieInfo = new List<MovieInfo>();

            foreach (var movie in movies)
            {
                if (movie.MovieId.Equals(movieId))
                {
                    FilteredMovieInfo.Add(new MovieInfo(movie.EntryId, movie.MovieId, movie.Title, movie.Language, movie.Duration, movie.ReleaseYear));
                }
            }
            return FilteredMovieInfo;
        }



        public List<MovieInfo> Filter(List<MovieInfo> movies)
        {
            string userInput;

            Console.WriteLine("Search Selected");
            Console.WriteLine("Search by movie id?");

            userInput = Console.ReadLine();
            while (Regex.IsMatch(userInput, @"^\d+$") == false)
            {
                Console.WriteLine("Please enter a number");
                userInput = Console.ReadLine();

            }
            var filteredMovies = SearchMovieInfo(movies, Convert.ToInt32(userInput));
            Console.WriteLine("Json file created");
            return filteredMovies;


        }
    }
}
