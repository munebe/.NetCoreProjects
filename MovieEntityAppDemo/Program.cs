
using MovieEntityAppDemo;

CategoryDal categoryDal=new CategoryDal();
MovieDal movieDal = new MovieDal();
/*categoryDal.AddCategoryByList(new List<Category>()
    {
        new Category(){Name = "Korku"},
        new Category(){Name = "Komedi"},
        new Category(){Name = "Dram"}
    }
);*/



/*movieDal.AddMovieByList(new List<Movie>()
{
    new Movie(){Name = "The Ring",CategoryId = categoryDal.GetCategoryByName("Korku").Id },
    new Movie(){Name = "The Hangover",CategoryId = categoryDal.GetCategoryByName("Komedi").Id }
});*/

foreach (var movie in movieDal.GetAllMovie())
{
    Console.WriteLine(movie.Category.Name);
}



