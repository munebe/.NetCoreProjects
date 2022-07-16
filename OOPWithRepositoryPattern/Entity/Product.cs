namespace OOPWithRepositoryPattern.Entity;

public class Product:IEntity
{
   
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }
    public int Id { get; set; }
}