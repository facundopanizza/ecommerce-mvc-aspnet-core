using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Migrations
{
    public partial class seedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://brain-images-ssl.cdn.dixons.com/4/4/10188244/u_10188244.jpg", "https://brain-images-ssl.cdn.dixons.com/4/4/10188244/u_10188244.jpg", true, true, "Specifications Mfr Part Number: BX80684I99900K Model: Intel Core i9-9900K Processor Core Name: Coffee Lake Core Count: 8 Thread Count: 16 Clock Speed: 3. 6 GHz Max Turbo Frequency: 5. 0 GHz Smart Cache: 16 MB DMI3: 8. 0 GT/s Lithography: 14nm Socket: LGA 1151 Max Thermal Design Power: 95W Memory Type: DDR4-2666 Processor Graphics: Intel UHD Graphics 630 Graphics Base Frequency: 350 MHz Graphics Max Dynamic Frequency: 1. 20 GHz Max CPU Configuration: 1 Advanced Technologies: Intel Optane Memory Supported Intel Turbo Boost 2. 0 Technology Intel vPro Platform Eligibility Intel Hyper-Threading Technology Intel Virtualization Technology (VT-x) Intel Virtualization Technology for Directed I/O (VT-d) Intel TSX-NI Intel 64 Instruction Set 64-bit Instruction Set Extensions - Intel SSE4. 1, Intel SSE4. 2, Intel AVX2 Idle States Enhanced Intel Speed Step Technology Thermal Monitoring Technologies Intel Identity Protection Technology Intel Stable Image Platform Program (SIPP) Intel AES New Instructions Secure Key Intel Software Guard Extensions (Intel SGX) Intel Memory Protection Extensions (Intel MPX) Intel OS Guard Intel Trusted Execution Technology Execute Disable Bit Intel Boot Guard.", "Intel i9 9900K", 60000m, "8 Cores up to 5.0GHz Turbo unlocked" },
                    { 2, 1, "https://images-na.ssl-images-amazon.com/images/I/71S31CWSs3L._AC_SL1093_.jpg", "https://images-na.ssl-images-amazon.com/images/I/71S31CWSs3L._AC_SL1093_.jpg", true, true, "AMD Ryzen 9 3900X 12-core, 24-thread unlocked desktop processor with Wraith Prism LED Cooler", "AMD Ryzen 9 3900X ", 65000m, "12-core, 24-thread unlocked" },
                    { 3, 2, "https://images-na.ssl-images-amazon.com/images/I/81D46VNLb9L._AC_SL1500_.jpg", "https://images-na.ssl-images-amazon.com/images/I/81D46VNLb9L._AC_SL1500_.jpg", false, false, "XFX Radeon RX 580 GTS XXX Edition 1386MHz OC+, 8GB GDDR5, VR Ready, Dual BIOS, 3xDP HDMI DVI, AMD Graphics Card (RX-580P8DFD6)", "XFX Radeon RX 580", 24000m, "GTS XXX Edition 1386MHz OC+, 8GB GDDR5" },
                    { 4, 3, "https://images-na.ssl-images-amazon.com/images/I/61qHbO1rbdL._AC_SL1280_.jpg", "https://images-na.ssl-images-amazon.com/images/I/61qHbO1rbdL._AC_SL1280_.jpg", true, true, "Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2) CL16 BL2K8G32C16U4BL (Black) ", "Crucial Ballistix RGB 3200 MGz DDR4 8GBx2", 60000m, "Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
