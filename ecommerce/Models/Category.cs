using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("Name")]
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}