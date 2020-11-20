using System.Collections.Generic;
using ecommerce.Models;

namespace ecommerce.ViewModels
{
  public class HomeViewModel
  {
    public IEnumerable<Product> ProductsOfTheWeek { get; set; }
  }
}