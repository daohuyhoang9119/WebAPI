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
            migrationBuilder.DropForeignKey(
                name: "FK_Oder_User_UserId",
                table: "Oder");

            migrationBuilder.DropForeignKey(
                name: "FK_OderItem_Oder_Order_Id",
                table: "OderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OderItem_Product_Product_Id",
                table: "OderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OderItem",
                table: "OderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Oder",
                table: "Oder");

            migrationBuilder.DropIndex(
                name: "IX_Oder_UserId",
                table: "Oder");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Oder");

            migrationBuilder.RenameTable(
                name: "OderItem",
                newName: "OrderItem");

            migrationBuilder.RenameTable(
                name: "Oder",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_OderItem_Product_Id",
                table: "OrderItem",
                newName: "IX_OrderItem_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OderItem_Order_Id",
                table: "OrderItem",
                newName: "IX_OrderItem_Order_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_User_Id",
                table: "Order",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_User_Id",
                table: "Order",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_Order_Id",
                table: "OrderItem",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Product_Product_Id",
                table: "OrderItem",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_User_Id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_Order_Id",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Product_Product_Id",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_User_Id",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OderItem");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Oder");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_Product_Id",
                table: "OderItem",
                newName: "IX_OderItem_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_Order_Id",
                table: "OderItem",
                newName: "IX_OderItem_Order_Id");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Oder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OderItem",
                table: "OderItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Oder",
                table: "Oder",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Oder_UserId",
                table: "Oder",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oder_User_UserId",
                table: "Oder",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OderItem_Oder_Order_Id",
                table: "OderItem",
                column: "Order_Id",
                principalTable: "Oder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OderItem_Product_Product_Id",
                table: "OderItem",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
