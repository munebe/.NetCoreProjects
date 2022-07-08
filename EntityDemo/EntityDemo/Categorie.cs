using System.ComponentModel.DataAnnotations;

namespace EntityDemo;

public class Categorie
{
    [Key]       
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}