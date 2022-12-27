using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
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
                    Discount = table.Column<int>(type: "int", nullable: false),
                    RatingAverage = table.Column<int>(name: "Rating_Average", type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(name: "Brand_Name", type: "nvarchar(max)", nullable: false),
                    ImageUrl1 = table.Column<string>(name: "ImageUrl_1", type: "nvarchar(max)", nullable: false),
                    ImageUrl2 = table.Column<string>(name: "ImageUrl_2", type: "nvarchar(max)", nullable: false),
                    ImageUrl3 = table.Column<string>(name: "ImageUrl_3", type: "nvarchar(max)", nullable: false),
                    Createdat = table.Column<DateTime>(name: "Created_at", type: "datetime2", nullable: false),
                    Updatedat = table.Column<DateTime>(name: "Updated_at", type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(name: "Category_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_Category_Id",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<double>(name: "Total_Amount", type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(name: "Created_At", type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(name: "Updated_At", type: "datetime2", nullable: false),
                    UserId = table.Column<int>(name: "User_Id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_User_User_Id",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Oder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(name: "Created_At", type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(name: "Updated_At", type: "datetime2", nullable: false),
                    TotalAmount = table.Column<double>(name: "Total_Amount", type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId0 = table.Column<int>(name: "User_Id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oder_User_UserId",
                        column: x => x.UserId,
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(name: "Image_Url", type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false),
                    CartId = table.Column<int>(name: "Cart_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_Cart_Id",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Product_Product_Id",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(name: "Image_Url", type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false),
                    OrderId = table.Column<int>(name: "Order_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OderItem_Oder_Order_Id",
                        column: x => x.OrderId,
                        principalTable: "Oder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OderItem_Product_Product_Id",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_User_Id",
                table: "Cart",
                column: "User_Id",
                unique: true,
                filter: "[User_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Cart_Id",
                table: "CartItem",
                column: "Cart_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Product_Id",
                table: "CartItem",
                column: "Product_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Oder_UserId",
                table: "Oder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OderItem_Order_Id",
                table: "OderItem",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OderItem_Product_Id",
                table: "OderItem",
                column: "Product_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_Id",
                table: "Product",
                column: "Category_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "OderItem");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Oder");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
