using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ecommerce.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortDescription = table.Column<string>(type: "text", nullable: false),
                    LongDescription = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImageName = table.Column<string>(type: "text", nullable: true),
                    IsProductOfTheWeek = table.Column<bool>(type: "boolean", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Processor" },
                    { 2, "GPU" },
                    { 3, "RAM" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageName", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "1.jpg", true, "Specifications Mfr Part Number: BX80684I99900K Model: Intel Core i9-9900K Processor Core Name: Coffee Lake Core Count: 8 Thread Count: 16 Clock Speed: 3. 6 GHz Max Turbo Frequency: 5. 0 GHz Smart Cache: 16 MB DMI3: 8. 0 GT/s Lithography: 14nm Socket: LGA 1151 Max Thermal Design Power: 95W Memory Type: DDR4-2666 Processor Graphics: Intel UHD Graphics 630 Graphics Base Frequency: 350 MHz Graphics Max Dynamic Frequency: 1. 20 GHz Max CPU Configuration: 1 Advanced Technologies: Intel Optane Memory Supported Intel Turbo Boost 2. 0 Technology Intel vPro Platform Eligibility Intel Hyper-Threading Technology Intel Virtualization Technology (VT-x) Intel Virtualization Technology for Directed I/O (VT-d) Intel TSX-NI Intel 64 Instruction Set 64-bit Instruction Set Extensions - Intel SSE4. 1, Intel SSE4. 2, Intel AVX2 Idle States Enhanced Intel Speed Step Technology Thermal Monitoring Technologies Intel Identity Protection Technology Intel Stable Image Platform Program (SIPP) Intel AES New Instructions Secure Key Intel Software Guard Extensions (Intel SGX) Intel Memory Protection Extensions (Intel MPX) Intel OS Guard Intel Trusted Execution Technology Execute Disable Bit Intel Boot Guard.", "Intel i9 9900K", 60000m, "8 Cores up to 5.0GHz Turbo unlocked" },
                    { 2, 1, "2.jpg", true, "AMD Ryzen 9 3900X 12-core, 24-thread unlocked desktop processor with Wraith Prism LED Cooler", "AMD Ryzen 9 3900X ", 65000m, "12-core, 24-thread unlocked" },
                    { 5, 1, "5.jpg", false, "Intel Core i7-9700K Desktop Processor 8 Cores up to 4.9 GHz Turbo unlocked LGA1151 300 Series 95W", "Intel Core i7-9700K", 45000m, "Intel Core i7-9700K Desktop Processor 8 Cores" },
                    { 3, 2, "3.jpg", false, "XFX Radeon RX 580 GTS XXX Edition 1386MHz OC+, 8GB GDDR5, VR Ready, Dual BIOS, 3xDP HDMI DVI, AMD Graphics Card (RX-580P8DFD6)", "XFX Radeon RX 580", 24000m, "GTS XXX Edition 1386MHz OC+, 8GB GDDR5" },
                    { 6, 2, "6.jpg", true, "XFX RX 5600 XT THICC III PRO - 14GBPS 6GB GDDR6 BOOST UP TO 1750MHz 3xDP HDMI Graphics Card RX-56XT6TF48 ", "XFX RX 5600 XT THICC III PRO", 50000m, "XFX RX 5600 XT THICC III PRO - 14GBPS 6GB GDDR6" },
                    { 4, 3, "4.jpg", true, "Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2) CL16 BL2K8G32C16U4BL (Black) ", "Crucial Ballistix RGB 3200 MGz DDR4 8GBx2", 60000m, "Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2)" },
                    { 7, 3, "7.jpg", true, "G.Skill 32GB DDR4 Trident Z Royal Gold 3200Mhz PC4-25600 CL16 1.35V Dual Channel Kit (2x16GB) ", "G.Skill 2x16GB DDR4 Trident Z Royal Gold", 60000m, "G.Skill 32GB DDR4 Trident Z Royal Gold 3200Mhz PC4-25600" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
