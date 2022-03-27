using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingStore.API.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories (Name) Values('Dresses')");
            migrationBuilder.Sql("Insert into Categories (Name) Values('Pants')");
            migrationBuilder.Sql("Insert into Categories (Name) Values('Shirts')");
            migrationBuilder.Sql("Insert into Categories (Name) Values('Shorts')");
            migrationBuilder.Sql("Insert into Categories (Name) Values('Lingerie')");

            migrationBuilder.Sql("Insert into Products(Name, Price, Size, Color, Description, Stock, RegisterDate, CategoryId) " +
               "Values('Cropped to React', '50.00', 'P', 'Red', 'Woman reacts, put on a cropped!', 50, now(), " +
               "(Select CategoryId from Categories where Name='Shirts'))");

            migrationBuilder.Sql("Insert into Products(Name, Price, Size, Color, Description, Stock, RegisterDate, CategoryId) " +
               "Values('Jeans Pants', '130.00', '40', 'Medium Blue Wash', ' These Classic Skinny Jeans in medium blue are the perfect pair for everyday wear.', 30, now(), " +
               "(Select CategoryId from Categories where Name='Pants'))");

            migrationBuilder.Sql("Insert into Products(Name, Price, Size, Color, Description, Stock, RegisterDate, CategoryId) " +
               "Values('Mini-Dress', '100.00', 'M', 'Black', 'Beautiful black mini dress', 20, now(), " +
               "(Select CategoryId from Categories where Name='Dresses'))");

            migrationBuilder.Sql("Insert into Products(Name, Price, Size, Color, Description, Stock, RegisterDate, CategoryId) " +
               "Values('Mini-Dress', '100.00', 'G', 'Black', 'Beautiful black mini dress', 25, now(), " +
               "(Select CategoryId from Categories where Name='Dresses'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categories");
            migrationBuilder.Sql("Delete from Products");
        }
    }
}
