using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Movie
    {
        public string MovieName { get; set; }
        public double MoviePuan { get; set; }

        public Movie(string movieName, double moviePuan)
        {
            MovieName = movieName;
            MoviePuan = moviePuan;

        }
    }
}
