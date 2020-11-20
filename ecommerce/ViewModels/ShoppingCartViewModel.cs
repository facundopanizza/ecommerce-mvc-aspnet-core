using ecommerce.Models;

namespace ecommerce.ViewModels
{
  public class ShoppingCartViewModel
  {
    public ShoppingCart ShoppingCart { get; set; }
    public decimal ShoppingCartTotal { get; set; }
  }
}