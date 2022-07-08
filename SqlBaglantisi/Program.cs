
using SqlBaglantisi;
using System.Configuration;


string connectionString = ConfigurationManager.
            ConnectionStrings["AzureString"].ConnectionString;

MovieDal movieDal =new MovieDal(connectionString);

#region Add
/*
Movie movie = new Movie("Merhaba");
Console.WriteLine(movieDal.addMovie(movie));
*/
#endregion

#region Get
// List<Movie> movies= movieDal.getMovieList();
/*
 foreach (Movie item in movies)
{
    Console.WriteLine(item.Name);
}
*/
#endregion

#region Remove
/*
List<Movie> movies = movieDal.getMovieList();
Console.WriteLine(movieDal.removeMovie(movies[0]));
*/
#endregion











