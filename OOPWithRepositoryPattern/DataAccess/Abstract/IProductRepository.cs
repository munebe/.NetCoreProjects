using OOPWithRepositoryPattern.Entity;

namespace OOPWithRepositoryPattern.DataAccess.Abstract;

public interface IProductRepository:IRepository<Product>
{
    public void GetProductsByCategory();

}