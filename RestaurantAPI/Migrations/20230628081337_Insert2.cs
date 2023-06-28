using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantAPI.Migrations
{
    /// <inheritdoc />
    public partial class Insert2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Adresses_AdressId",
                table: "Restaurants");

            migrationBuilder.RenameColumn(
                name: "AdressId",
                table: "Restaurants",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Restaurants_AdressId",
                table: "Restaurants",
                newName: "IX_Restaurants_AddressId");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Adresses_AddressId",
                table: "Restaurants",
                column: "AddressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Adresses_AddressId",
                table: "Restaurants");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Restaurants",
                newName: "AdressId");

            migrationBuilder.RenameIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants",
                newName: "IX_Restaurants_AdressId");

            migrationBuilder.AlterColumn<bool>(
                name: "ContactNumber",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "ContactEmail",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Adresses_AdressId",
                table: "Restaurants",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
