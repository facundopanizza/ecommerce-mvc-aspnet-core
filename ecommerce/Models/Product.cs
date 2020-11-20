using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace ecommerce.Models
{
  public class Product
  {
    [Key]
    public int ProductId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string ShortDescription { get; set; }

    [Required]
    public string LongDescription { get; set; }

    [Required]
    public decimal Price { get; set; }

    public string ImageName { get; set; }

    [NotMapped]
    [Required]
    public IFormFile Image { get; set; }

    [Required]
    public bool IsProductOfTheWeek { get; set; }

    [Required]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
  }
}