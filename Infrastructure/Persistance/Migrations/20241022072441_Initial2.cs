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
            migrationBuilder.DropIndex(
                name: "IX_Users_Phone1_Phone2",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Phone1_Phone2",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone1_Phone2",
                table: "Users",
                columns: new[] { "Phone1", "Phone2" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Phone1_Phone2",
                table: "Employees",
                columns: new[] { "Phone1", "Phone2" },
                unique: true);
        }
    }
}
