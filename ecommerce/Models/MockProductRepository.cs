using System.Collections.Generic;
using System.Linq;

namespace ecommerce.Models
{
  public class MockProductRepository : IProductRepository
  {
    private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

    public IEnumerable<Product> AllProducts =>
    new List<Product>
    {
      new Product {
        ProductId=1,
        Name="Intel i9 9900K",
        Price=60000,
        ShortDescription="8 Cores up to 5.0GHz Turbo unlocked",
        LongDescription="Specifications Mfr Part Number: BX80684I99900K Model: Intel Core i9-9900K Processor Core Name: Coffee Lake Core Count: 8 Thread Count: 16 Clock Speed: 3. 6 GHz Max Turbo Frequency: 5. 0 GHz Smart Cache: 16 MB DMI3: 8. 0 GT/s Lithography: 14nm Socket: LGA 1151 Max Thermal Design Power: 95W Memory Type: DDR4-2666 Processor Graphics: Intel UHD Graphics 630 Graphics Base Frequency: 350 MHz Graphics Max Dynamic Frequency: 1. 20 GHz Max CPU Configuration: 1 Advanced Technologies: Intel Optane Memory Supported Intel Turbo Boost 2. 0 Technology Intel vPro Platform Eligibility Intel Hyper-Threading Technology Intel Virtualization Technology (VT-x) Intel Virtualization Technology for Directed I/O (VT-d) Intel TSX-NI Intel 64 Instruction Set 64-bit Instruction Set Extensions - Intel SSE4. 1, Intel SSE4. 2, Intel AVX2 Idle States Enhanced Intel Speed Step Technology Thermal Monitoring Technologies Intel Identity Protection Technology Intel Stable Image Platform Program (SIPP) Intel AES New Instructions Secure Key Intel Software Guard Extensions (Intel SGX) Intel Memory Protection Extensions (Intel MPX) Intel OS Guard Intel Trusted Execution Technology Execute Disable Bit Intel Boot Guard.",
        CategoryId=1,
        InStock=true,
        IsProductOfTheWeek=true,
        ImageThumbnailUrl="https://brain-images-ssl.cdn.dixons.com/4/4/10188244/u_10188244.jpg",
        ImageUrl="https://brain-images-ssl.cdn.dixons.com/4/4/10188244/u_10188244.jpg",
        Category=_categoryRepository.AllCategories.FirstOrDefault(x => x.CategoryId == 1)
      },
      new Product {
        ProductId=2,
        Name="AMD Ryzen 9 3900X ",
        Price=65000,
        ShortDescription="12-core, 24-thread unlocked",
        LongDescription="AMD Ryzen 9 3900X 12-core, 24-thread unlocked desktop processor with Wraith Prism LED Cooler",
        CategoryId=1,
        InStock=true,
        IsProductOfTheWeek=true,
        ImageThumbnailUrl="https://images-na.ssl-images-amazon.com/images/I/71S31CWSs3L._AC_SL1093_.jpg",
        ImageUrl="https://images-na.ssl-images-amazon.com/images/I/71S31CWSs3L._AC_SL1093_.jpg",
        Category=_categoryRepository.AllCategories.FirstOrDefault(x => x.CategoryId == 1)
      },
      new Product {
        ProductId=3,
        Name="XFX Radeon RX 580",
        Price=24000,
        ShortDescription="GTS XXX Edition 1386MHz OC+, 8GB GDDR5",
        LongDescription="XFX Radeon RX 580 GTS XXX Edition 1386MHz OC+, 8GB GDDR5, VR Ready, Dual BIOS, 3xDP HDMI DVI, AMD Graphics Card (RX-580P8DFD6)",
        CategoryId=2,
        InStock=false,
        IsProductOfTheWeek=false,
        ImageThumbnailUrl="https://images-na.ssl-images-amazon.com/images/I/81D46VNLb9L._AC_SL1500_.jpg",
        ImageUrl="https://images-na.ssl-images-amazon.com/images/I/81D46VNLb9L._AC_SL1500_.jpg",
        Category=_categoryRepository.AllCategories.FirstOrDefault(x => x.CategoryId == 2)
      },
      new Product {
        ProductId=4,
        Name="Crucial Ballistix RGB 3200 MGz DDR4 8GBx2",
        Price=60000,
        ShortDescription="Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2)",
        LongDescription="Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2) CL16 BL2K8G32C16U4BL (Black) ",
        CategoryId=3,
        InStock=true,
        IsProductOfTheWeek=true,
        ImageThumbnailUrl="https://images-na.ssl-images-amazon.com/images/I/61qHbO1rbdL._AC_SL1280_.jpg",
        ImageUrl="https://images-na.ssl-images-amazon.com/images/I/61qHbO1rbdL._AC_SL1280_.jpg",
        Category=_categoryRepository.AllCategories.FirstOrDefault(x => x.CategoryId == 3)
      }
    };

    public IEnumerable<Product> ProductsOfTheWeek => throw new System.NotImplementedException();

    public Product GetProductById(int productId)
    {
      return AllProducts.FirstOrDefault(p => p.ProductId == productId);
    }
  }
}