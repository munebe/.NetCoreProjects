namespace OOPWithRepositoryPattern.Entity;

public class Category : IEntity
{ //IEntity'den Id alanını implement ettik
    
    public string Name { get; set; }
    public int Id { get; set; }
}