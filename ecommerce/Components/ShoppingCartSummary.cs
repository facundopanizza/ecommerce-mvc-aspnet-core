using ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Models
{
  public class ShoppingCartSummary : ViewComponent
  {
    private readonly ShoppingCart _shoppingCart;

    public ShoppingCartSummary(ShoppingCart shoppingCart)
    {
      _shoppingCart = shoppingCart;
    }


    public IViewComponentResult Invoke()
    {
      var items = _shoppingCart.GetShoppingCartItems();
      _shoppingCart.ShoppingCartItems = items;

      var shoppingCartViewModel = new ShoppingCartViewModel
      {
        ShoppingCart = _shoppingCart
      };

      return View(shoppingCartViewModel);
    }
  }
}