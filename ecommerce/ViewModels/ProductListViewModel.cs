using System.Collections.Generic;
using ecommerce.Models;
using X.PagedList;

namespace ecommerce.ViewModels
{
  public class ProductListViewModel
  {
    public IPagedList<Product> Products { get; set; }
    public int Page { get; set; }
    public string Order { get; set; }
    public string searchName { get; set; }
  }
}