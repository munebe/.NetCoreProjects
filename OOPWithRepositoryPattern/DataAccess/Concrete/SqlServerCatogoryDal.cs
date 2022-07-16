using OOPWithRepositoryPattern.DataAccess.Abstract;

namespace OOPWithRepositoryPattern.DataAccess.Concrete;

public class SqlServerCatogoryDal:ICategoryRepository
{
    public void GetById()
    {
        Console.WriteLine("SqlServer GetById");
    }

    public void Add()
    {
        Console.WriteLine("SqlServer Add");
    }

    public void Update()
    {
        Console.WriteLine("SqlServer Update");
    }

    public void Delete()
    {
        Console.WriteLine("SqlServer Delete");
    }
}