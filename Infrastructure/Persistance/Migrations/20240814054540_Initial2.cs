using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Employees",
                newName: "PositionUzRu");

            migrationBuilder.AddColumn<string>(
                name: "PositionEn",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PositionRu",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PositionUz",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionEn",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PositionRu",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PositionUz",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "PositionUzRu",
                table: "Employees",
                newName: "Position");
        }
    }
}
