using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(name: "Category_Name", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(name: "Role_Id", type: "int", nullable: false),
                    FirstName = table.Column<string>(name: "First_Name", type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(name: "Date_Of_Birth", type: "datetime2", nullable: false),
                    CompanyName = table.Column<string>(name: "Company_Name", type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(name: "Address_1", type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(name: "Address_2", type: "nvarchar(max)", nullable: false),
                    TownCity = table.Column<string>(name: "Town_City", type: "nvarchar(max)", nullable: false),
                    ZipPostCode = table.Column<int>(name: "ZipPost_Code", type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(name: "Phone_Number", type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created_Date", type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(name: "Updated_Date", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(name: "Category_Id", type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    RatingAverage = table.Column<int>(name: "Rating_Average", type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(name: "Brand_Name", type: "nvarchar(max)", nullable: false),
                    Createdat = table.Column<DateTime>(name: "Created_at", type: "datetime2", nullable: false),
                    Updatedat = table.Column<DateTime>(name: "Updated_at", type: "datetime2", nullable: false),
                    CategoryId0 = table.Column<int>(name: "CategoryId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId0,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
