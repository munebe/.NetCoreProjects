using System.Configuration;
using System.Data.Odbc;

namespace SqlBaglantisi
{
    public class MovieDal
    {
        public string connectionString { get; set; }
        public MovieDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

    
        public int addMovie(Movie movie)
        {
            using (var conn = new OdbcConnection(this.connectionString))
            {
                try
                {
                    conn.Open();
                    OdbcCommand command = new OdbcCommand($"insert into Movie(name) values('{movie.Name}')", conn);
                    return command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return -1;
                   
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        public List<Movie> getMovieList()
        {
            using (var conn = new OdbcConnection(this.connectionString))
            {
                List<Movie> movieList = new List<Movie>();
                try
                {
                    conn.Open();
                    OdbcCommand command = new OdbcCommand("select name from Movie", conn);
                    OdbcDataReader reader = command.ExecuteReader();
                    movieList = new List<Movie>();
                    while (reader.Read())
                    {
                        movieList.Add(new Movie((string)reader[0]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
                return movieList;
            }
           
        }

        public int removeMovie(Movie movie)
        {
            using (var conn = new OdbcConnection(this.connectionString))
            {
                try
                {
                    conn.Open();
                    OdbcCommand command = new OdbcCommand($"delete from Movie where name = '{movie.Name}'", conn);
                    return command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return -1;
                    
                }
                finally
                {
                    conn.Close();
                }
            }

        }

    }
}
