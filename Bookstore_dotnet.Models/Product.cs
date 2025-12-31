using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore_dotnet.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Title { get; set; }

    [Required]
    public required string Description { get; set; }

    [Required]
    public required string ISBN { get; set; }

    [Required]
    public required string Author { get; set; }

    [Required]
    [Display(Name = "List Price")]
    [Range(1, 1000)]
    public decimal ListPrice { get; set; }

    [Required]
    [Display(Name = "Price for 1-50")]
    [Range(1, 1000)]
    public decimal Price { get; set; }

    [Required]
    [Display(Name = "Price for 51-100")]
    [Range(1, 1000)]
    public decimal Price50 { get; set; }

    [Required]
    [Display(Name = "Price for 100+")]
    [Range(1, 1000)]
    public decimal Price100 { get; set; }

    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category Category { get; set; } 
    public string ImageUrl { get; set; }
}