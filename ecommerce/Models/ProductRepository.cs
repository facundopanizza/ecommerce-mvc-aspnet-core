using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System;
using ecommerce.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ecommerce.Models
{
  public class ProductRepository : IProductRepository
  {
    private readonly AppDbContext _appDbContext;
    private readonly IWebHostEnvironment _hostEnviroment;

    public ProductRepository(AppDbContext appDbContext, IWebHostEnvironment hostEnvironment)
    {
      _appDbContext = appDbContext;
      _hostEnviroment = hostEnvironment;
    }

    public IEnumerable<Product> ProductsOfTheWeek
    {
      get
      {
        return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsProductOfTheWeek == true);
      }
    }

    public Product GetProductById(int productId)
    {
      return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
    }

    public bool Add(Product product)
    {
      product.ImageName = UploadedFile(product);

      _appDbContext.Products.Add(product);
      _appDbContext.SaveChanges();

      return true;
    }

    private string UploadedFile(string image)
    {
      throw new NotImplementedException();
    }

    public bool Update(Product product)
    {
      var productToUpdate = _appDbContext.Products.FirstOrDefault(p => p.ProductId == product.ProductId);

      string imageToDeletePath = Path.Combine(_hostEnviroment.WebRootPath, "images", "products", productToUpdate.ImageName);

      productToUpdate.CategoryId = product.CategoryId;
      productToUpdate.Image = product.Image;
      productToUpdate.IsProductOfTheWeek = product.IsProductOfTheWeek;
      productToUpdate.LongDescription = product.LongDescription;
      productToUpdate.Name = product.Name;
      productToUpdate.Price = product.Price;
      productToUpdate.ShortDescription = product.ShortDescription;

      productToUpdate.ImageName = UploadedFile(product);
      _appDbContext.Update(productToUpdate);

      if (System.IO.File.Exists(imageToDeletePath))
      {
        System.IO.File.Delete(imageToDeletePath);
      }

      _appDbContext.SaveChanges();

      return true;
    }

    public bool Delete(int productId)
    {
      var product = _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);

      if (product == null)
      {
        return false;
      }

      string imageToDeletePath = Path.Combine(_hostEnviroment.WebRootPath, "images", "products", product.ImageName);

      if (System.IO.File.Exists(imageToDeletePath))
      {
        System.IO.File.Delete(imageToDeletePath);
      }

      _appDbContext.Products.Remove(product);
      _appDbContext.SaveChanges();

      return true;
    }

    public IEnumerable<Product> GetProducts(string name = null, bool order = false)
    {
      IEnumerable<Product> products;

      if (name != null)
      {
        if (order)
        {
          products = _appDbContext.Products.Where(p => p.Name.ToLower().Contains(name.Trim().ToLower())).OrderBy(p => p.Price);
        }
        else
        {
          products = _appDbContext.Products.Where(p => p.Name.ToLower().Contains(name.Trim().ToLower())).OrderByDescending(p => p.Price);
        }
      }
      else if (order)
      {
        products = _appDbContext.Products.OrderBy(p => p.Price);
      }
      else
      {
        products = _appDbContext.Products.OrderByDescending(p => p.Price);
      }

      return products;
    }

    private string UploadedFile(Product product)
    {
      string uniqueFileName = null;

      if (product.Image != null)
      {
        string uploadsFolder = Path.Combine(_hostEnviroment.WebRootPath, "images/products");
        uniqueFileName = Guid.NewGuid().ToString() + "_" + product.Image.FileName;
        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
          product.Image.CopyTo(fileStream);
        }
      }
      return uniqueFileName;
    }
  }
}