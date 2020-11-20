using ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Models
{
  public class ProductController : Controller
  {
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
      _productRepository = productRepository;
      _categoryRepository = categoryRepository;
    }

    public ViewResult List()
    {
      ProductListViewModel productListViewModel = new ProductListViewModel();
      productListViewModel.Products = _productRepository.AllProducts;

      productListViewModel.CurrentCategory = "Processors";
      return View(productListViewModel);
    }
  }
}