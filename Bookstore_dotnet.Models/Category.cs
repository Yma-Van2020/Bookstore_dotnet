using System.ComponentModel.DataAnnotations;

namespace Bookstore_dotnet.Models;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    [Display(Name = "Category Name")]
    public required string Name { get; set; }

    [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100")]
    [Display(Name = "Display Order")]
    public int DisplayOrder { get; set; }
}
