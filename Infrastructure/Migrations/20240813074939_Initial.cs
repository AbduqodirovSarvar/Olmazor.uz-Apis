using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobFairs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    ReceptionDays = table.Column<int[]>(type: "integer[]", nullable: false),
                    ReceptionTime = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: false),
                    DescriptionEn = table.Column<string>(type: "text", nullable: false),
                    DescriptionRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobFairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: false),
                    DescriptionEn = table.Column<string>(type: "text", nullable: false),
                    DescriptionRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TasksAndFunctions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: false),
                    DescriptionEn = table.Column<string>(type: "text", nullable: false),
                    DescriptionRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksAndFunctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsefulLinks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsefulLinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Userrole = table.Column<int>(type: "integer", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FirstnameEn = table.Column<string>(type: "text", nullable: false),
                    FirstnameRu = table.Column<string>(type: "text", nullable: false),
                    LastnameEn = table.Column<string>(type: "text", nullable: false),
                    LastnameRu = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Phone1 = table.Column<string>(type: "text", nullable: false),
                    Phone2 = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubEmployeeCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubEmployeeCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubEmployeeCategories_EmployeesCategories_EmployeeCategoryId",
                        column: x => x.EmployeeCategoryId,
                        principalTable: "EmployeesCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceptionDays = table.Column<int[]>(type: "integer[]", nullable: false),
                    ReceptionTime = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: false),
                    DescriptionEn = table.Column<string>(type: "text", nullable: false),
                    DescriptionRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abouts_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PostCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: false),
                    DescriptionEn = table.Column<string>(type: "text", nullable: false),
                    DescriptionRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_PostCategories_PostCategoryId",
                        column: x => x.PostCategoryId,
                        principalTable: "PostCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SubEmployeeCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    BirthPlace = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    WorkFromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    WorkPlace = table.Column<string>(type: "text", nullable: false),
                    ReceptionDays = table.Column<int[]>(type: "integer[]", nullable: false),
                    ReceptionTime = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FirstnameEn = table.Column<string>(type: "text", nullable: false),
                    FirstnameRu = table.Column<string>(type: "text", nullable: false),
                    LastnameEn = table.Column<string>(type: "text", nullable: false),
                    LastnameRu = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Phone1 = table.Column<string>(type: "text", nullable: false),
                    Phone2 = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_SubEmployeeCategories_SubEmployeeCategoryId",
                        column: x => x.SubEmployeeCategoryId,
                        principalTable: "SubEmployeeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    NameUzRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: false),
                    DescriptionEn = table.Column<string>(type: "text", nullable: false),
                    DescriptionRu = table.Column<string>(type: "text", nullable: false),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sectors_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sectors_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_LocationId",
                table: "Abouts",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_NameEn_NameUz_NameRu_NameUzRu",
                table: "Contacts",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Phone1_Phone2",
                table: "Employees",
                columns: new[] { "Phone1", "Phone2" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SubEmployeeCategoryId",
                table: "Employees",
                column: "SubEmployeeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesCategories_NameEn_NameUz_NameRu_NameUzRu",
                table: "EmployeesCategories",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobFairs_NameEn_NameUz_NameRu_NameUzRu",
                table: "JobFairs",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_NameEn_NameUz_NameRu_NameUzRu",
                table: "Locations",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostCategories_NameEn_NameUz_NameRu_NameUzRu",
                table: "PostCategories",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_NameEn_NameUz_NameRu_NameUzRu",
                table: "Posts",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostCategoryId",
                table: "Posts",
                column: "PostCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_EmployeeId",
                table: "Sectors",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_LocationId",
                table: "Sectors",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_NameEn_NameUz_NameRu_NameUzRu",
                table: "Sectors",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Slides_NameEn_NameUz_NameRu_NameUzRu",
                table: "Slides",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubEmployeeCategories_EmployeeCategoryId",
                table: "SubEmployeeCategories",
                column: "EmployeeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubEmployeeCategories_NameEn_NameUz_NameRu_NameUzRu",
                table: "SubEmployeeCategories",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TasksAndFunctions_NameEn_NameUz_NameRu_NameUzRu",
                table: "TasksAndFunctions",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsefulLinks_NameEn_NameUz_NameRu_NameUzRu",
                table: "UsefulLinks",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone1_Phone2",
                table: "Users",
                columns: new[] { "Phone1", "Phone2" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "JobFairs");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "TasksAndFunctions");

            migrationBuilder.DropTable(
                name: "UsefulLinks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "SubEmployeeCategories");

            migrationBuilder.DropTable(
                name: "EmployeesCategories");
        }
    }
}
