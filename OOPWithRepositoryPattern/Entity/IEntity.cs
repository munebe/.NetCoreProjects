namespace OOPWithRepositoryPattern.Entity;

public interface IEntity
{ 
    // tüm entitylerde Id alanı olduğu için bir interface ile tanımlama yapabiliriz
    int Id { get; set; }
}