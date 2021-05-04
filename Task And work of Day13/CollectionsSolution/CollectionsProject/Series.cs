using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CollectionsProject
{
    class Series : IComparable<Series>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Episodes { get; set; }
        public double EachEpisodeDuration { get; set; }
        public int NumberOfSeasons { get; set; }
        public string Stream { get; set; }
        public int CompareTo([AllowNull] Series other)
        {
            return this.EachEpisodeDuration.CompareTo(other.EachEpisodeDuration);
        }

        public void TakeSeriesDetails()
        {
            Console.WriteLine("Please enter the series name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the season's number of episodes");
            Episodes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the series show case platform");
            Stream = Console.ReadLine();
            if ((Stream == "HBO" || Stream == "hbo" || Stream == "Hbo") & Episodes > 10)
            {
                Console.WriteLine("Invalied number of episodes");
            }
            else if ((Stream == "NETFLIX" || Stream == "netflix" || Stream == "Netflix") & Episodes > 10)
            {
                Console.WriteLine("Invalied number of episodes");
            }
            else if ((Stream == "STARZ" || Stream == "starz" || Stream == "Starz") & Episodes > 22)
            {
                Console.WriteLine("Invalied number of episodes");
            }
            else if ((Stream == "DC" || Stream == "dc" || Stream == "Dc") & Episodes > 24)
            {
                Console.WriteLine("Invalied number of episodes");
            }
            Console.WriteLine("Please enter the serie's number of seasons");
            NumberOfSeasons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Duration of Each episode");
            double duration = 0;
            while(!double.TryParse(Console.ReadLine(),out duration))
            {
                Console.WriteLine("Invalied entry of duration. Please try again");
            }
            EachEpisodeDuration = duration;
        }
        public override string ToString()
        {
            return "Id: " + Id + "\nseries Name " + Name +"\nNumber of seasons "+NumberOfSeasons+ "\nNumber of episodes " + Episodes + "\nEach episode duration" + EachEpisodeDuration;
        }
    }
}
