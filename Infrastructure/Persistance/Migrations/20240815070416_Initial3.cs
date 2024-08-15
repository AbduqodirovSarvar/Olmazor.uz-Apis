using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "Employees",
                newName: "NationalityUzRu");

            migrationBuilder.AddColumn<string>(
                name: "NationalityEn",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalityRu",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalityUz",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NationalityEn",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NationalityRu",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NationalityUz",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "NationalityUzRu",
                table: "Employees",
                newName: "Nationality");
        }
    }
}
