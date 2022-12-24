using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Product_Id",
                table: "CartItem",
                column: "Product_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Product_Product_Id",
                table: "CartItem",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Product_Product_Id",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_Product_Id",
                table: "CartItem");
        }
    }
}
