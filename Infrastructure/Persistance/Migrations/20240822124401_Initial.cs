﻿using System;
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
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Category = table.Column<int>(type: "integer", nullable: false),
                    NationalityEn = table.Column<string>(type: "text", nullable: true),
                    NationalityUz = table.Column<string>(type: "text", nullable: true),
                    NationalityRu = table.Column<string>(type: "text", nullable: true),
                    NationalityUzRu = table.Column<string>(type: "text", nullable: true),
                    NationalityKaa = table.Column<string>(type: "text", nullable: true),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    BirthPlaceUz = table.Column<string>(type: "text", nullable: true),
                    BirthPlaceEn = table.Column<string>(type: "text", nullable: true),
                    BirthPlaceRu = table.Column<string>(type: "text", nullable: true),
                    BirthPlaceUzRu = table.Column<string>(type: "text", nullable: true),
                    BirthPlaceKaa = table.Column<string>(type: "text", nullable: true),
                    PositionEn = table.Column<string>(type: "text", nullable: true),
                    PositionUz = table.Column<string>(type: "text", nullable: true),
                    PositionRu = table.Column<string>(type: "text", nullable: true),
                    PositionUzRu = table.Column<string>(type: "text", nullable: true),
                    PositionKaa = table.Column<string>(type: "text", nullable: true),
                    WorkFromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    WorkPlaceUz = table.Column<string>(type: "text", nullable: true),
                    WorkPlaceEn = table.Column<string>(type: "text", nullable: true),
                    WorkPlaceRu = table.Column<string>(type: "text", nullable: true),
                    WorkPlaceUzRu = table.Column<string>(type: "text", nullable: true),
                    WorkPlaceKaa = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeUz = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeEn = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeRu = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeUzRu = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeKaa = table.Column<string>(type: "text", nullable: true),
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
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    NameUzRu = table.Column<string>(type: "text", nullable: true),
                    NameKaa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Category = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    NameUzRu = table.Column<string>(type: "text", nullable: true),
                    NameKaa = table.Column<string>(type: "text", nullable: true),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: true),
                    DescriptionKaa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
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
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    NameUzRu = table.Column<string>(type: "text", nullable: true),
                    NameKaa = table.Column<string>(type: "text", nullable: true),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: true),
                    DescriptionKaa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
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
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    NameUzRu = table.Column<string>(type: "text", nullable: true),
                    NameKaa = table.Column<string>(type: "text", nullable: true)
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
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceptionTimeUz = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeEn = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeRu = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeUzRu = table.Column<string>(type: "text", nullable: true),
                    ReceptionTimeKaa = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: true),
                    DescriptionKaa = table.Column<string>(type: "text", nullable: true)
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
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    NameUzRu = table.Column<string>(type: "text", nullable: true),
                    NameKaa = table.Column<string>(type: "text", nullable: true),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true),
                    DescriptionUzRu = table.Column<string>(type: "text", nullable: true),
                    DescriptionKaa = table.Column<string>(type: "text", nullable: true)
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
                name: "IX_Locations_NameEn_NameUz_NameRu_NameUzRu",
                table: "Locations",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_NameEn_NameUz_NameRu_NameUzRu",
                table: "Posts",
                columns: new[] { "NameEn", "NameUz", "NameRu", "NameUzRu" },
                unique: true);

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
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "UsefulLinks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
