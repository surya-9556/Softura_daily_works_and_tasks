using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOExampleProject
{
    class Program
    {
        string conString;
        SqlConnection con;
        SqlCommand cmd;
        public Program()
        {
            conString = "server = DESKTOP-87C5QHV;Integrated security = true;Initial catalog = pubs";
            con = new SqlConnection(conString);
        }
        void FetchMovieFromDatabase()
        {
            string strCmd = "Select * from tblMovie";
            cmd = new SqlCommand(strCmd,con);
            try
            {
                con.Open();
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read())
                {
                    Console.WriteLine("Movie Id : "+drMovies[0]);
                    Console.WriteLine("Movie name : " + drMovies[1]);
                    Console.WriteLine("Movies duration : " + drMovies[2]);
                    Console.WriteLine("------------------------------------");
                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void FetchOneMovieFromDatabase()
        {
            string strCmd = "Select * from tblMovie where id = @mid";
            cmd = new SqlCommand(strCmd, con);
            try
            {
                con.Open();
                Console.WriteLine("Please enter the Id");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.Add("@mid", SqlDbType.Int);
                cmd.Parameters[0].Value = id;
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read())
                {
                    Console.WriteLine("Movie Id : " + drMovies[0]);
                    Console.WriteLine("Movie name : " + drMovies[1]);
                    Console.WriteLine("Movies duration : " + drMovies[2]);
                    Console.WriteLine("------------------------------------");
                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void UpdateMovie()
        {
            Console.WriteLine("Please enter the movie Id that need to be changed");
            int id = Convert.ToInt32(Console.ReadLine());
            int choice = 0;
            do
            {
                Console.WriteLine("Select what you want to update");
                Console.WriteLine("1. Update duration of movie");
                Console.WriteLine("2. Update name of the movie");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter the movie duration");
                        float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
                        UpdateMovieDuration(id, mDuration);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the movie name");
                        string mName = Console.ReadLine();
                        UpdateMovieName(id, mName);
                        break;
                    case 3:
                        Console.WriteLine("Exiting..........!!");
                        FetchMovieFromDatabase();
                        break;
                    default:
                        break;
                }
            } while (choice != 3);
            
        }

        void UpdateMovieName(int id, string mName)
        {
            string strCmd = "update tblMovie set name = @name where id = @mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            cmd.Parameters.AddWithValue("@name", mName);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Movie name Updated");
                }
                else
                {
                    Console.WriteLine("No no not done");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void UpdateMovieDuration(int id,float mDuration)
        {
            string strCmd = "update tblMovie set duration = @duration where id = @mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            cmd.Parameters.AddWithValue("@duration", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Movie duration Updated");
                }
                else
                {
                    Console.WriteLine("No no not done");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void DeleteMovie()
        {
            Console.WriteLine("Please enter the movie Id");
            int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the movie duration");
            //float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
            string strCmd = "delete from tblMovie where id = @mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Movie deleted");
                }
                else
                {
                    Console.WriteLine("No no not done");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void AddMovie()
        {
            Console.WriteLine("Please enter the movie name");
            string mName = Console.ReadLine();
            Console.WriteLine("Please enter the movie duration");
            float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()),2);
            string strCmd = "insert into tblMovie(name,duration) values(@mname,@dur)";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mname", mName);
            cmd.Parameters.AddWithValue("@dur", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Movie inserted");
                }
                else
                {
                    Console.WriteLine("No no not done");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add or insert the data");
                Console.WriteLine("2. Update the data");
                Console.WriteLine("3. Delete the unwanted data");
                Console.WriteLine("4. Print all the data");
                Console.WriteLine("5. Print single data from data base");
                Console.WriteLine("6. Exit");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Select your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddMovie();
                        break;
                    case 2:
                        UpdateMovie();
                        break;
                    case 3:
                        DeleteMovie();
                        break;
                    case 4:
                        FetchMovieFromDatabase();
                        break;
                    case 5:
                        FetchOneMovieFromDatabase();
                        break;
                    case 6:
                        Console.WriteLine("Exiting.............!!");
                        break;
                    default:
                        break;
                }
            } while (choice != 6);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintMenu();
            Console.ReadKey();
        }
    }
}