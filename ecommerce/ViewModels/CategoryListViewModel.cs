using ecommerce.Models;
using X.PagedList;

namespace ecommerce.ViewModels
{
  public class CategoryListViewModel
  {
    public IPagedList<Category> Categories { get; set; }
    public int Page { get; set; }
    public string Order { get; set; }
  }
}