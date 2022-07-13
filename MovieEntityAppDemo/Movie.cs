using System.ComponentModel.DataAnnotations;

namespace MovieEntityAppDemo;

public class Movie
{
    [Key]
    public int Id { get; set; }
    
    public string Name { get; set; }

    public Category Category { get; set; }
    
    public int CategoryId { get; set; }
}