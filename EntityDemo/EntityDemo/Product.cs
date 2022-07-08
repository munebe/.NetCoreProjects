using System.ComponentModel.DataAnnotations;

namespace EntityDemo;

public class Product
{   [Key]
    public int Id { get; set; }

    //DataAnnotations
    [MaxLength(100)]
    [Required]
    public string Name { get; set; }
    
    public decimal Price { get; set; }
}