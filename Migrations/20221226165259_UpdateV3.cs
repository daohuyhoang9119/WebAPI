using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_User_Id",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_User_Id",
                table: "Cart");

            migrationBuilder.AddColumn<string>(
                name: "Image_Url",
                table: "CartItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "Cart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_User_Id",
                table: "Cart",
                column: "User_Id",
                unique: true,
                filter: "[User_Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_User_Id",
                table: "Cart",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_User_Id",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_User_Id",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "Image_Url",
                table: "CartItem");

            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "Cart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_User_Id",
                table: "Cart",
                column: "User_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_User_Id",
                table: "Cart",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
