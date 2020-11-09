using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace EagleEye
{
    class Context
    {
        public static void WriteMovies(List<MovieInfo> movies, string output)
        {
            try
            {
                var writer = new StreamWriter(new FileStream(output, FileMode.Create, FileAccess.ReadWrite));

                var serialized = JsonConvert.SerializeObject(movies, Formatting.Indented);

                writer.Write(serialized);

                writer.Flush();

                writer.Close();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Error in output string");
            }
        }

        public static void WriteMovies(IEnumerable<MovieStats> movies, string output)
        {
            try
            {
                var writer = new StreamWriter(new FileStream(output, FileMode.Create, FileAccess.ReadWrite));

                var serialized = JsonConvert.SerializeObject(movies, Formatting.Indented);

                writer.Write(serialized);

                writer.Flush();

                writer.Close();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Error in output string");
            }
        }

    }
}
