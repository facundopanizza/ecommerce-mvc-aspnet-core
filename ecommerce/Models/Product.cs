using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
  public class Product
  {
    public int ProductId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string ShortDescription { get; set; }
    [Required]
    public string LongDescription { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    [Required]
    public string ImageThumbnailUrl { get; set; }
    [Required]
    public bool IsProductOfTheWeek { get; set; }
    [Required]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
  }
}