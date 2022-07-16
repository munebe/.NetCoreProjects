using OOPWithRepositoryPattern.DataAccess.Abstract;

namespace OOPWithRepositoryPattern.BusinessLogicLayer;

public class ProductManager:IProductRepository
{
    private IProductRepository _repository;

    public ProductManager(IProductRepository repository)
    {
        _repository = repository;
    }


    public void GetById()
    {
        _repository.GetById();
    }

    public void Add()
    {
        _repository.Add();
    }

    public void Update()
    {
      _repository.Update();
    }

    public void Delete()
    {
      _repository.Delete();
    }

    public void GetProductsByCategory()
    {
       _repository.GetProductsByCategory();
    }
}