using ecommerce.Models;
using ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
  public class HomeController : Controller
  {
    private readonly IProductRepository _productRepository;

    public HomeController(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public IActionResult Index()
    {
      var homeViewModel = new HomeViewModel
      {
        ProductsOfTheWeek = _productRepository.ProductsOfTheWeek
      };

      return View(homeViewModel);
    }
  }
}