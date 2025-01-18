using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _20250118_ShopAspNetMvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Discount", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "iPhone is a line of smartphones designed and marketed by Apple Inc. They run Apple's iOS mobile operating system. The first iPhone was released on June 29, 2007, and an iPhone has been released every year since then.", 10, "https://m.media-amazon.com/images/I/61bK6PMOC3L.jpg", "iPhone", 699m, 10 },
                    { 2, "The iMac is a family of all-in-one Macintosh desktop computers designed and built by Apple Inc. It has been the primary part of Apple's consumer desktop offerings since its debut in August 1998, and has evolved through seven distinct forms.", 0, "https://m.media-amazon.com/images/I/71gqlRrQCuL.jpg", "iMac", 1999m, 20 },
                    { 3, "The AK-74 is an assault rifle developed in the early 1970s by Russian designer Mikhail Kalashnikov as the replacement for the earlier AKM. It uses a smaller 5.45×39mm cartridge, replacing the 7.62×39mm chambering of earlier Kalashnikov-pattern weapons.", 30, "https://modernfirearms.net/wp-content/uploads/2010/10/ak74-1980-tula.jpg", "Ak-74", 200m, 100 },
                    { 4, "The Škoda Octavia is a small family car produced by the Czech car manufacturer Škoda Auto since the end of 1996. It shares its name with an earlier Škoda model produced between 1959 and 1971. There have been three generations of the modern-era Octavia model to date, delivered with five-door liftback saloon or five-door estate styles only.", 0, "https://vag-com-perm.ru/f1d43dc617f7.jpg", "Skoda Octavia A5FL 2011", 7000m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
