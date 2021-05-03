using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CollectionsProject
{
    class Movie : IComparable<Movie>
    {
        public int id { get; set; }
        public string name { get; set; } 
        public double Duration { get; set; }

        public int CompareTo([AllowNull] Movie other)
        {
            return this.Duration.CompareTo(other.Duration);
        }

        public void TakeMovieDetails()
        {
            Console.WriteLine("Pleae Enter the movie name");
            name = Console.ReadLine();
            double duration = 0;
            Console.WriteLine("Plese enter the duration of movie");
            while (!double.TryParse(Console.ReadLine(),out duration))
            {
                Console.WriteLine("Invalied entry for duration. Try again");
            }
            Duration = duration;
        }

        public override string ToString()
        {
            return "Movie Id: " + id + "Movie Name: " + name + "Duration: " + Duration;
        }
    }
}
