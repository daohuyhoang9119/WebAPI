using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<double>(name: "Total_Amount", type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(name: "Created_At", type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(name: "Updated_At", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(name: "Category_Name", type: "nvarchar(500)", maxLength: 500, nullable: false)
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
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TokenCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TokenExpired = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(name: "Date_Of_Birth", type: "datetime2", nullable: false),
                    CompanyName = table.Column<string>(name: "Company_Name", type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(name: "Address_1", type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(name: "Address_2", type: "nvarchar(max)", nullable: false),
                    TownCity = table.Column<string>(name: "Town_City", type: "nvarchar(max)", nullable: false),
                    ZipPostCode = table.Column<int>(name: "ZipPost_Code", type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(name: "Phone_Number", type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created_Date", type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(name: "Updated_Date", type: "datetime2", nullable: false),
                    CartId = table.Column<int>(name: "Cart_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Cart_Cart_Id",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ImageUrl1 = table.Column<string>(name: "ImageUrl_1", type: "nvarchar(max)", nullable: false),
                    ImageUrl2 = table.Column<string>(name: "ImageUrl_2", type: "nvarchar(max)", nullable: false),
                    ImageUrl3 = table.Column<string>(name: "ImageUrl_3", type: "nvarchar(max)", nullable: false),
                    Createdat = table.Column<DateTime>(name: "Created_at", type: "datetime2", nullable: false),
                    Updatedat = table.Column<DateTime>(name: "Updated_at", type: "datetime2", nullable: false),
                    CategoryId0 = table.Column<int>(name: "CategoryId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId0,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(name: "User_Id", type: "int", nullable: false),
                    UserId0 = table.Column<int>(name: "UserId", type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(name: "Created_At", type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(name: "Updated_At", type: "datetime2", nullable: false),
                    TotalAmount = table.Column<double>(name: "Total_Amount", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId0,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(name: "Cart_Id", type: "int", nullable: false),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false),
                    OrderId = table.Column<int>(name: "Order_Id", type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    cartId = table.Column<int>(type: "int", nullable: false),
                    OrderId0 = table.Column<int>(name: "OrderId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_cartId",
                        column: x => x.cartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Order_OrderId",
                        column: x => x.OrderId0,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_cartId",
                table: "CartItem",
                column: "cartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_OrderId",
                table: "CartItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cart_Id",
                table: "User",
                column: "Cart_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Cart");
        }
    }
}
