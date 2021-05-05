using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsProject
{
    class ManageSeries
    {
        //List<Series> TSeries;
        Dictionary<int, Series> TSeries;
        public ManageSeries()
        {
            //TSeries = new List<Series>();
            TSeries = new Dictionary<int, Series>();
        }
        public void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print All Series");
                Console.WriteLine("2. Print Series name by Id");
                Console.WriteLine("3. Add new series");
                Console.WriteLine("4. Update the series");
                Console.WriteLine("5. Sort the series");
                Console.WriteLine("6. Delete the series");
                Console.WriteLine("7. Add series");
                Console.WriteLine("8. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PrintAllSeries();
                        break;
                    case 2:
                        PrintSeriesNameById();
                        break;
                    case 3:
                        AddNewSeries();
                        break;
                    case 4:
                        UpdateSeries();
                        break;
                    case 5:
                        SortingSeries();
                        break;
                    case 6:
                        DeleteSeries();
                        break;
                    case 7:
                        Series series = CreateSeries();
                        TSeries.Add(series.Id,series);
                        break;
                    default:
                        Console.WriteLine("Invalied Choice");
                        break;
                }
            } while (choice != 8);
        }

        public void PrintAllSeries()
        {
            if (TSeries.Count == 0)
            {
                Console.WriteLine("No movies are present");
            }
            else
            {
                foreach (var item in TSeries.Keys)
                {
                    PrintSeries(TSeries[item]);
                }
            }
        }

        public void PrintSeries(Series series)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(series);
            Console.WriteLine("----------------------");
        }

        public Series CreateSeries()
        {
            Series series = new Series();
            series.Id = GenrateId();
            series.TakeSeriesDetails();
            return series;
        }

        public int GenrateId()
        {
            if(TSeries.Count == 0)
            {
                return 1;
            }
            List<int> ids = TSeries.Keys.ToList();
            ids.Sort();
            int Id = TSeries[TSeries.Count - 1].Id;
            Id++;
            return Id;
        }

        public int GetMovieIndexById(int id)
        {
            List<KeyValuePair<int, Series>> mlist = TSeries.ToList();
            return mlist.FindIndex(m => m.Key == id);

            //int result = Convert.ToInt32(TSeries.ContainsKey(id));
            //return result;

        }

        private void DeleteSeries()
        {
            Console.WriteLine("Please enter the movie id to be deleted");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                TSeries.Remove(GetMovieIndexById(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops something went wrong");
            }
        }

        public void SortingSeries()
        {
            if(TSeries.Count != 0)
            {
                TSeries.OrderBy(i => i.Key);
            }
            else
            {
                Console.WriteLine("No elemets to sort");
            }
        }

        private void UpdateSeries()
        {
            Console.WriteLine("Please choose the Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select what do you want to update name or Duration or number of episodes or number of seasons or all");
            string choice = Console.ReadLine();
            string Name;
            double Duration;
            int Episodes;
            int NumberOfSeasons;
            string Stream;
            switch (choice)
            {
                case "Name":
                    Console.WriteLine("Please enter the new series name");
                    Name = Console.ReadLine();
                    UpdateSeriesName(id,Name);
                    break;
                case "Duration":
                    Console.WriteLine("Please enter the new duration of Each episode");
                    while (!double.TryParse(Console.ReadLine(), out Duration))
                    {
                        Console.WriteLine("Invalied entry of duration. Please try again");
                    }
                    UpdateEpisodeDuration(id,Duration);
                    break;
                case "NumberOfSeasons":
                    Console.WriteLine("Please enter the new serie's number of seasons");
                    NumberOfSeasons = Convert.ToInt32(Console.ReadLine());
                    UpdateSeriesSeasons(id,NumberOfSeasons);
                    break;
                case "NumberOfEpisodes":
                    Console.WriteLine("Please enter the new seasons's number of episodes");
                    Episodes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the new series show case platform");
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
                    UpdateSeriesEpisodes(id,Episodes);
                    break;
                default:
                    Console.WriteLine("Invalied Choice");
                    break;
            }
        }
        public Series UpdateSeriesName(int Id,string name)
        {
            Series series = null;
            int idx = GetMovieIndexById(Id);
            if (idx != -1)
            {
                TSeries[idx].Name = name;
                series = TSeries[idx];
            }
            return series;
        }
        public Series UpdateEpisodeDuration(int Id,double Duration)
        {
            Series series = null;
            int idx = GetMovieIndexById(Id);
            if (idx != -1)
            {
                TSeries[idx].EachEpisodeDuration = Duration;
                series = TSeries[idx];
            }
            return series;
        }
        public Series UpdateSeriesSeasons(int Id,int Seasons)
        {
            Series series = null;
            int idx = GetMovieIndexById(Id);
            if (idx != -1)
            {
                TSeries[idx].NumberOfSeasons = Seasons;
                series = TSeries[idx];
            }
            return series;
        }
        public Series UpdateSeriesEpisodes(int Id, int episodes)
        {
            Series series = null;
            int idx = GetMovieIndexById(Id);
            if (idx != -1)
            {
                TSeries[idx].Episodes = episodes;
                series = TSeries[idx];
            }
            return series;
        }
        public void AddNewSeries()
        {
            int choice = 0;
            do
            {
                Series series = CreateSeries();
                TSeries.Add(series.Id,series);
                Console.WriteLine("Do you wish to add another series?? if yes enter any number other than zero. To exit enter 0");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException FE)
                {
                    Console.WriteLine("Invlied choice");
                }
            } while (choice != 0);
        }

        public void PrintSeriesNameById()
        {
            Console.WriteLine("Please enter the series ID");
            int idx = Convert.ToInt32(Console.ReadLine());
            if(idx >= 0)
            {
                PrintSeries(TSeries[idx]);
            }
            else
            {
                Console.WriteLine("No such id is persent");
            }
        }

        static void Main(string[] a)
        {
            ManageSeries manage = new ManageSeries();
            manage.PrintMenu();
        }
    }
}
