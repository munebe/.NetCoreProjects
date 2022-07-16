using OOPWithRepositoryPattern.DataAccess.Abstract;

namespace OOPWithRepositoryPattern.DataAccess.Concrete;

public class MySqlProductDal:IProductRepository
{
    public void GetById()
    {
        Console.WriteLine("MySql GetById");
    }

    public void Add()
    {
        Console.WriteLine("MySql Add");
    }

    public void Update()
    {
        Console.WriteLine("MySql Update");
    }

    public void Delete()
    {
        Console.WriteLine("MySql Delete");
    }

    public void GetProductsByCategory()
    {
        Console.WriteLine("MySql GetProductsByCategory");
    }
}