using Microsoft.EntityFrameworkCore;

namespace ecommerce.Models
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // create categories
      modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Processor" });
      modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "GPU" });
      modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "RAM" });

      // create products
      modelBuilder.Entity<Product>().HasData(new Product
      {
        ProductId = 1,
        Name = "Intel i9 9900K",
        Price = 60000,
        ShortDescription = "8 Cores up to 5.0GHz Turbo unlocked",
        LongDescription = "Specifications Mfr Part Number: BX80684I99900K Model: Intel Core i9-9900K Processor Core Name: Coffee Lake Core Count: 8 Thread Count: 16 Clock Speed: 3. 6 GHz Max Turbo Frequency: 5. 0 GHz Smart Cache: 16 MB DMI3: 8. 0 GT/s Lithography: 14nm Socket: LGA 1151 Max Thermal Design Power: 95W Memory Type: DDR4-2666 Processor Graphics: Intel UHD Graphics 630 Graphics Base Frequency: 350 MHz Graphics Max Dynamic Frequency: 1. 20 GHz Max CPU Configuration: 1 Advanced Technologies: Intel Optane Memory Supported Intel Turbo Boost 2. 0 Technology Intel vPro Platform Eligibility Intel Hyper-Threading Technology Intel Virtualization Technology (VT-x) Intel Virtualization Technology for Directed I/O (VT-d) Intel TSX-NI Intel 64 Instruction Set 64-bit Instruction Set Extensions - Intel SSE4. 1, Intel SSE4. 2, Intel AVX2 Idle States Enhanced Intel Speed Step Technology Thermal Monitoring Technologies Intel Identity Protection Technology Intel Stable Image Platform Program (SIPP) Intel AES New Instructions Secure Key Intel Software Guard Extensions (Intel SGX) Intel Memory Protection Extensions (Intel MPX) Intel OS Guard Intel Trusted Execution Technology Execute Disable Bit Intel Boot Guard.",
        CategoryId = 1,
        IsProductOfTheWeek = true,
        ImageName = "1.jpg",
      });
      modelBuilder.Entity<Product>().HasData(new Product
      {
        ProductId = 2,
        Name = "AMD Ryzen 9 3900X ",
        Price = 65000,
        ShortDescription = "12-core, 24-thread unlocked",
        LongDescription = "AMD Ryzen 9 3900X 12-core, 24-thread unlocked desktop processor with Wraith Prism LED Cooler",
        CategoryId = 1,
        IsProductOfTheWeek = true,
        ImageName = "2.jpg",
      });
      modelBuilder.Entity<Product>().HasData(new Product
      {
        ProductId = 3,
        Name = "XFX Radeon RX 580",
        Price = 24000,
        ShortDescription = "GTS XXX Edition 1386MHz OC+, 8GB GDDR5",
        LongDescription = "XFX Radeon RX 580 GTS XXX Edition 1386MHz OC+, 8GB GDDR5, VR Ready, Dual BIOS, 3xDP HDMI DVI, AMD Graphics Card (RX-580P8DFD6)",
        CategoryId = 2,
        IsProductOfTheWeek = false,
        ImageName = "3.jpg",
      });
      modelBuilder.Entity<Product>().HasData(new Product
      {
        ProductId = 4,
        Name = "Crucial Ballistix RGB 3200 MGz DDR4 8GBx2",
        Price = 60000,
        ShortDescription = "Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2)",
        LongDescription = "Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2) CL16 BL2K8G32C16U4BL (Black) ",
        CategoryId = 3,
        IsProductOfTheWeek = true,
        ImageName = "4.jpg",
      });
      modelBuilder.Entity<Product>().HasData(new Product
      {
        ProductId = 5,
        Name = "Intel Core i7-9700K",
        Price = 45000,
        ShortDescription = "Intel Core i7-9700K Desktop Processor 8 Cores",
        LongDescription = "Intel Core i7-9700K Desktop Processor 8 Cores up to 4.9 GHz Turbo unlocked LGA1151 300 Series 95W",
        CategoryId = 1,
        IsProductOfTheWeek = false,
        ImageName = "5.jpg",
      });
      modelBuilder.Entity<Product>().HasData(new Product
      {
        ProductId = 6,
        Name = "XFX RX 5600 XT THICC III PRO",
        Price = 50000,
        ShortDescription = "XFX RX 5600 XT THICC III PRO - 14GBPS 6GB GDDR6",
        LongDescription = "XFX RX 5600 XT THICC III PRO - 14GBPS 6GB GDDR6 BOOST UP TO 1750MHz 3xDP HDMI Graphics Card RX-56XT6TF48 ",
        CategoryId = 2,
        IsProductOfTheWeek = true,
        ImageName = "6.jpg",
      });
      modelBuilder.Entity<Product>().HasData(new Product
      {
        ProductId = 7,
        Name = "G.Skill 2x16GB DDR4 Trident Z Royal Gold",
        Price = 60000,
        ShortDescription = "G.Skill 32GB DDR4 Trident Z Royal Gold 3200Mhz PC4-25600",
        LongDescription = "G.Skill 32GB DDR4 Trident Z Royal Gold 3200Mhz PC4-25600 CL16 1.35V Dual Channel Kit (2x16GB) ",
        CategoryId = 3,
        IsProductOfTheWeek = true,
        ImageName = "7.jpg",
      });
    }
  }
}