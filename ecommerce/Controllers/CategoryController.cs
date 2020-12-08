using System.Threading.Tasks;
using ecommerce.Models;
using ecommerce.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace ecommerce.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [AllowAnonymous]
        public ViewResult List(string name, bool order, int? page)
        {
            var categoryListViewModel = new CategoryListViewModel();
            var categories = _categoryRepository.AllCategories;

            var pageNumber = page ?? 1;

            categoryListViewModel.Categories = categories.ToPagedList(pageNumber, 15);
            categoryListViewModel.Page = pageNumber;

            ViewBag.searchName = name;
            ViewBag.order = order;

            return View(categoryListViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Add(Category category)
        {
            if (!ModelState.IsValid) return View("Create");

            await _categoryRepository.AddAsync(category);
            return RedirectToAction("List");
        }

        public async Task<IActionResult> Edit(int categoryId)
        {
            var category = await _categoryRepository.GetCategoryByIdAsync(categoryId);

            return View(category);
        }

        public async Task<IActionResult> Update(Category category)
        {
            if (!ModelState.IsValid) return View("Edit");

            await _categoryRepository.UpdateAsync(category);

            return RedirectToAction("List");
        }

        public async Task<IActionResult> Delete(int categoryId)
        {
            await _categoryRepository.DeleteAsync(categoryId);

            return RedirectToAction("List");
        }
    }
}