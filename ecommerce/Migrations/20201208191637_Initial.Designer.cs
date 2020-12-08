﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerce.Models;

namespace ecommerce.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201208191637_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ecommerce.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Processor"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "GPU"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "RAM"
                        });
                });

            modelBuilder.Entity("ecommerce.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ImageName = "1.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "Specifications Mfr Part Number: BX80684I99900K Model: Intel Core i9-9900K Processor Core Name: Coffee Lake Core Count: 8 Thread Count: 16 Clock Speed: 3. 6 GHz Max Turbo Frequency: 5. 0 GHz Smart Cache: 16 MB DMI3: 8. 0 GT/s Lithography: 14nm Socket: LGA 1151 Max Thermal Design Power: 95W Memory Type: DDR4-2666 Processor Graphics: Intel UHD Graphics 630 Graphics Base Frequency: 350 MHz Graphics Max Dynamic Frequency: 1. 20 GHz Max CPU Configuration: 1 Advanced Technologies: Intel Optane Memory Supported Intel Turbo Boost 2. 0 Technology Intel vPro Platform Eligibility Intel Hyper-Threading Technology Intel Virtualization Technology (VT-x) Intel Virtualization Technology for Directed I/O (VT-d) Intel TSX-NI Intel 64 Instruction Set 64-bit Instruction Set Extensions - Intel SSE4. 1, Intel SSE4. 2, Intel AVX2 Idle States Enhanced Intel Speed Step Technology Thermal Monitoring Technologies Intel Identity Protection Technology Intel Stable Image Platform Program (SIPP) Intel AES New Instructions Secure Key Intel Software Guard Extensions (Intel SGX) Intel Memory Protection Extensions (Intel MPX) Intel OS Guard Intel Trusted Execution Technology Execute Disable Bit Intel Boot Guard.",
                            Name = "Intel i9 9900K",
                            Price = 60000m,
                            ShortDescription = "8 Cores up to 5.0GHz Turbo unlocked"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            ImageName = "2.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "AMD Ryzen 9 3900X 12-core, 24-thread unlocked desktop processor with Wraith Prism LED Cooler",
                            Name = "AMD Ryzen 9 3900X ",
                            Price = 65000m,
                            ShortDescription = "12-core, 24-thread unlocked"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            ImageName = "3.jpg",
                            IsProductOfTheWeek = false,
                            LongDescription = "XFX Radeon RX 580 GTS XXX Edition 1386MHz OC+, 8GB GDDR5, VR Ready, Dual BIOS, 3xDP HDMI DVI, AMD Graphics Card (RX-580P8DFD6)",
                            Name = "XFX Radeon RX 580",
                            Price = 24000m,
                            ShortDescription = "GTS XXX Edition 1386MHz OC+, 8GB GDDR5"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3,
                            ImageName = "4.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2) CL16 BL2K8G32C16U4BL (Black) ",
                            Name = "Crucial Ballistix RGB 3200 MGz DDR4 8GBx2",
                            Price = 60000m,
                            ShortDescription = "Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2)"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            ImageName = "5.jpg",
                            IsProductOfTheWeek = false,
                            LongDescription = "Intel Core i7-9700K Desktop Processor 8 Cores up to 4.9 GHz Turbo unlocked LGA1151 300 Series 95W",
                            Name = "Intel Core i7-9700K",
                            Price = 45000m,
                            ShortDescription = "Intel Core i7-9700K Desktop Processor 8 Cores"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            ImageName = "6.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "XFX RX 5600 XT THICC III PRO - 14GBPS 6GB GDDR6 BOOST UP TO 1750MHz 3xDP HDMI Graphics Card RX-56XT6TF48 ",
                            Name = "XFX RX 5600 XT THICC III PRO",
                            Price = 50000m,
                            ShortDescription = "XFX RX 5600 XT THICC III PRO - 14GBPS 6GB GDDR6"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            ImageName = "7.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "G.Skill 32GB DDR4 Trident Z Royal Gold 3200Mhz PC4-25600 CL16 1.35V Dual Channel Kit (2x16GB) ",
                            Name = "G.Skill 2x16GB DDR4 Trident Z Royal Gold",
                            Price = 60000m,
                            ShortDescription = "G.Skill 32GB DDR4 Trident Z Royal Gold 3200Mhz PC4-25600"
                        });
                });

            modelBuilder.Entity("ecommerce.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ecommerce.Models.Product", b =>
                {
                    b.HasOne("ecommerce.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ecommerce.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ecommerce.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ecommerce.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}