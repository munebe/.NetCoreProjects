namespace MovieEntityAppDemo;

public class MovieDal
{
    public List<Movie> GetAllMovie()
    {
        using (var db=new MovieAppContext())
        {
            return db.Movies.ToList();
        }   
    }
    public Movie GetMovieById(int Id)
    {
        using (var db=new MovieAppContext())
        {
            return db.Movies.Where(m => m.Id == Id).FirstOrDefault();
        }
    }

    public void RemoveMovie(Movie movie)
    {
        using (var db=new MovieAppContext())
        {
            Movie m = db.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
            if (m != null)
            {
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
            
        }
    }

    public void AddMovie(Movie movie)
    {
        using (var db=new MovieAppContext())
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
    }

    public void AddMovieByList(List<Movie> movies)
    {
        using (var db=new MovieAppContext())  
        {
            db.AddRange(movies);
            db.SaveChanges();
        }
    }
    
}