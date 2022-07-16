using OOPWithRepositoryPattern.DataAccess.Abstract;

namespace OOPWithRepositoryPattern.DataAccess.Concrete;

public class MySqlCategoryDal:ICategoryRepository
{
    public void GetById()
    {
        Console.WriteLine("Mysql GetById");
    }

    public void Add()
    {
        Console.WriteLine("Mysql Add");
    }

    public void Update()
    {
        Console.WriteLine("Mysql Update");
    }

    public void Delete()
    {
        Console.WriteLine("Mysql Delete");
    }
}