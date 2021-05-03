using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class ManageMovies
    {
        List<Movie> movies;
        public ManageMovies()
        {
            movies = new List<Movie>();
        }
        private int GenrateId()
        {
            if (movies.Count == 0)
                return 1;
            int id = movies[movies.Count - 1].id;
            id++;
            return id;
        }

        public Movie CreateMovie()
        {
            Movie movie = new Movie();
            movie.id = GenrateId();
            movie.TakeMovieDetails();
            return movie;
        }
        public int GetMovieIndexById(int id)
        {
            return movies.FindIndex(m => m.id == id);//lambda expression
        }

        public Movie UpdateMovieName(int id, string name)
        {
            Movie movie = null;
            int idx = GetMovieIndexById(id);
            if (idx != -1)
            {
                movies[idx].name = name;
                movie = movies[idx];
            }
            return movie;
        }

        public void PrintMovieById()
        {
            Console.WriteLine("Please enter the movie id to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());
            int idx = GetMovieIndexById(id);
            if(idx >= 0)
            {
                PrintMovie(movies[idx]);
            }
            else
            {
                Console.WriteLine("No such movie");
            }
        }

        public void DeleteMovie()
        {
            Console.WriteLine("Please enter the movie id to be deleted");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                movies.RemoveAt(GetMovieIndexById(id));
            }
            catch(Exception e)
            {
                Console.WriteLine("Oops something went wrong");
            }
        }
        public void PrintMovieById(int id)
        {
            int idx = GetMovieIndexById(id);
            if(idx != 1)
            {
                PrintMovie(movies[idx]);
            }
            else
            {
                Console.WriteLine("No such movie");
            }
        }
        public void PrintAllMovies()
        {
            if(movies.Count == 0)
            {
                Console.WriteLine("No movies are present");
            }
            else
            {
                foreach (var item in movies)
                {
                    PrintMovie(item);
                }
            }
        }
        void AddMovies()
        {
            int choice = 0;
            do
            {
                Movie movie = CreateMovie();
                movies.Add(movie);
                Console.WriteLine("Do you wish to add another movie?? if yes enter any number other than zero. To exit enter 0");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Not a correct input");
                }
            } while (choice !=0);
        }
        public void SortMovies()
        {
            if (movies.Count != 0)
            {
                movies.Sort();
            }
            else
            {
                Console.WriteLine("No elements to be sorted");
            }
        }
        public Movie UpdateDurationTime(int id, double Duration)
        {
            Movie movie = null;
            int idx = GetMovieIndexById(id);
            if (idx != -1)
            {
                movies[idx].Duration = Duration;
                movie = movies[idx];
            }
            return movie;
        }

        public void PrintMovie(Movie movie)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(movie);
            Console.WriteLine("-----------------------------");
        }

        void UpdateMovie()
        {
            Console.WriteLine("Please enter the id of movie");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select what do you want to update name or Duration or both");
            string choice = Console.ReadLine();
            string name;
            double Duration;
            switch (choice)
            {
                case "name":
                    Console.WriteLine("Please enter the updated Movie name");
                    name = Console.ReadLine();
                    UpdateMovieName(id, name);
                    break;
                case "Duration":
                    Console.WriteLine("Please enter the updated Duration Time");
                    while (!double.TryParse(Console.ReadLine(), out Duration))
                    {
                        Console.WriteLine("Invalied duration");
                    }
                    UpdateDurationTime(id, Duration);
                    break;
                case "both":
                    Console.WriteLine("Please enter the updated Movie name");
                    name = Console.ReadLine();
                    UpdateMovieName(id, name);
                    Console.WriteLine("Please enter the updated Duration Time");
                    while (!double.TryParse(Console.ReadLine(), out Duration))
                    {
                        Console.WriteLine("Invalied duration");
                    }
                    UpdateDurationTime(id, Duration);
                    break;
                default:
                    Console.WriteLine("Invalied choice");
                    break;
            }
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add a movie");
                Console.WriteLine("2. Add a list of Movies");
                Console.WriteLine("3. update the movie");
                Console.WriteLine("4. Delete the movie");
                Console.WriteLine("5. Print the movie by ID");
                Console.WriteLine("6. print all movies");
                Console.WriteLine("7. Sort movies by alphabet");
                Console.WriteLine("8. Exit from the application");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Movie movie = CreateMovie();
                        movies.Add(movie);
                        break;
                    case 2:
                        AddMovies();
                        break;
                    case 3:
                        UpdateMovie();
                        break;
                    case 4:
                        DeleteMovie();
                        break;
                    case 5:
                        PrintMovieById();
                        break;
                    case 6:
                        PrintAllMovies();
                        break;
                    case 7:
                        SortMovies();
                        break;
                    default:
                        Console.WriteLine("Invalied Choice");
                        break;
                }
            } while (choice != 8);
        }
        static void Main(string[] a)
        {
            ManageMovies movies = new ManageMovies();
            movies.PrintMenu();
        }
    }
}
