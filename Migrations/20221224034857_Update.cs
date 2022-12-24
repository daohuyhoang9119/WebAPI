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
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Product_Product",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_Product",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "Cart",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "CartItem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cart",
                table: "CartItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product",
                table: "CartItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Product",
                table: "CartItem",
                column: "Product");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Product_Product",
                table: "CartItem",
                column: "Product",
                principalTable: "Product",
                principalColumn: "Id");
        }
    }
}
