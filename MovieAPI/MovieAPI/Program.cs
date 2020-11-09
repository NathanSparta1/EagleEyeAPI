using System;

namespace EagleEye
{
    class Program
    {
        static void Main(string[] args)
        {
            string activity = "";

            Console.WriteLine("Create movie or Search movie by id? Type C for Create or S for Search");
            activity = Console.ReadLine();
            switch (activity.ToLower())
            {
                case "c":
                    PostMovie pos = new PostMovie();
                    pos.CreateMovie("metadata.csv");
                    break;

                case "s":
                    Console.WriteLine("Enter Name of output file");
                    string user = Console.ReadLine();
                    MetaDataContext.ExportMovies("metadata.csv", user + ".json");
                    break;

                default:
                    Console.WriteLine("No activity selected");
                    break;
            }
            /*string user;
            user = Console.ReadLine();
            StatsContext.ExportMovies("stats.csv", "metadata.csv", user + ".json");*/

        }
    }
}
