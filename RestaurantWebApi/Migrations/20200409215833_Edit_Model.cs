using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantWebApi.Migrations
{
    public partial class Edit_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Dishes");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Dishes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Dishes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Dishes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Dishes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfFood",
                table: "Dishes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "TypeOfFood",
                table: "Dishes");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Dishes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Dishes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Dishes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Dishes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
