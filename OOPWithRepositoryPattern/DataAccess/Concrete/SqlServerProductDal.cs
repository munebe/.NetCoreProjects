using OOPWithRepositoryPattern.DataAccess.Abstract;
using OOPWithRepositoryPattern.Entity;

namespace OOPWithRepositoryPattern.DataAccess.Concrete;

public class SqlServerProductDal:IProductRepository
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

    public void GetProductsByCategory()
    {
        Console.WriteLine("SqlServer GetProductsByCategory");
    }
}