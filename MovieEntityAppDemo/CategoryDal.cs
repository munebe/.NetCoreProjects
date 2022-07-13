namespace MovieEntityAppDemo;

public class CategoryDal
{
    public void AddCategoryByList(List<Category> categories)
    {
        using (var db=new MovieAppContext())
        {
            db.Categories.AddRange(categories);
            db.SaveChanges();
        }
    }
    
    public List<Category> GetAllCategories()
    {
        using (var db=new MovieAppContext())
        {
            return db.Categories.ToList();
        }
    }

    public Category GetCategoryById(int id)
    {
        using (var db=new MovieAppContext())
        {
            return db.Categories.Where(x => x.Id == id).FirstOrDefault();
        }
    }

    public void RemoveCategory(Category category)
    {
        using (var db=new MovieAppContext())
        {
            Category c = db.Categories.Where(x => x.Id == category.Id).FirstOrDefault();
            if (c != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            } 
        }
    }

    public void AddCategory(Category category)
    {
        using (var db=new MovieAppContext())
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }
    }

    public Category GetCategoryByName(string name)
    {
        using (var db=new MovieAppContext())
        {
            return db.Categories.FirstOrDefault(x => x.Name.Contains(name));
        }
    }
}