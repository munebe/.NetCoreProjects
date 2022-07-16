namespace OOPWithRepositoryPattern.DataAccess.Abstract;

public interface IRepository<TEntity> //Entity tipini parametre gibi yolluyoruz
{
    public void GetById();

    public void Add();

    public void Update();

    public void Delete();

}