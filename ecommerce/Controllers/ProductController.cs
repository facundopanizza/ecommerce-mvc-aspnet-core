using ecommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

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

    public ViewResult List(string name, bool order, int? page)
    {
      ProductListViewModel productListViewModel = new ProductListViewModel();
      var products = _productRepository.GetProducts(name, order);

      var pageNumber = page ?? 1;

      productListViewModel.Products = products.ToPagedList(pageNumber, 6);
      productListViewModel.Page = pageNumber;

      ViewBag.searchName = name;
      ViewBag.order = order;

      return View(productListViewModel);
    }

    public IActionResult Details(int id)
    {
      var product = _productRepository.GetProductById(id);

      if (product == null)
      {
        return NotFound();
      }

      return View(product);
    }

    public IActionResult Create()
    {
      ViewBag.Categories = new SelectList(_categoryRepository.AllCategories, "CategoryId", "CategoryName");
      return View();
    }

    public IActionResult Edit(int id)
    {
      var product = _productRepository.GetProductById(id);

      if (product == null)
      {
        return NotFound();
      }

      ViewBag.Categories = new SelectList(_categoryRepository.AllCategories, "CategoryId", "CategoryName");

      return View(product);
    }

    public IActionResult Add(Product product)
    {
      if (ModelState.IsValid)
      {
        _productRepository.Add(product);
        return RedirectToAction("List", "Product");
      }

      ViewBag.Categories = new SelectList(_categoryRepository.AllCategories, "CategoryId", "CategoryName");
      return View("Create");
    }

    public IActionResult Update(Product product)
    {
      if (ModelState.IsValid)
      {
        var productDb = _productRepository.Update(product);

        return RedirectToAction("List", "Product");
      }

      ViewBag.Categories = new SelectList(_categoryRepository.AllCategories, "CategoryId", "CategoryName");
      return View("Edit");
    }

    public IActionResult Delete(int id)
    {
      _productRepository.Delete(id);

      return RedirectToAction("List");
    }
  }
}