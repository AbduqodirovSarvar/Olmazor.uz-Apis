﻿// <auto-generated />
using System;
using Infrastructure.Persistance.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.About", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("DescriptionEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid");

                    b.Property<int[]>("ReceptionDays")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("ReceptionTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstnameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstnameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastnameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastnameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalityEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalityRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalityUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalityUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<string>("PositionEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PositionRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PositionUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PositionUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int[]>("ReceptionDays")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("ReceptionTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SubEmployeeCategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("WorkFromDate")
                        .HasColumnType("date");

                    b.Property<string>("WorkPlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("SubEmployeeCategoryId");

                    b.HasIndex("Phone1", "Phone2")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Domain.Entities.EmployeeCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("EmployeesCategories");
                });

            modelBuilder.Entity("Domain.Entities.JobFair", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("DescriptionEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int[]>("ReceptionDays")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("ReceptionTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("JobFairs");
                });

            modelBuilder.Entity("Domain.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Domain.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("DescriptionEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<Guid>("PostCategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PostCategoryId");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Domain.Entities.PostCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("PostCategories");
                });

            modelBuilder.Entity("Domain.Entities.Sector", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("DescriptionEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LocationId");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("Domain.Entities.Slide", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("DescriptionEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("Slides");
                });

            modelBuilder.Entity("Domain.Entities.SubEmployeeCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EmployeeCategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeCategoryId");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("SubEmployeeCategories");
                });

            modelBuilder.Entity("Domain.Entities.TaskOrFunction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("DescriptionEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DescriptionUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("TasksAndFunctions");
                });

            modelBuilder.Entity("Domain.Entities.UsefullLink", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUzRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameEn", "NameUz", "NameRu", "NameUzRu")
                        .IsUnique();

                    b.ToTable("UsefulLinks");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstnameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstnameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastnameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastnameRu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<int>("Userrole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone1", "Phone2")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.About", b =>
                {
                    b.HasOne("Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.HasOne("Domain.Entities.SubEmployeeCategory", "SubEmployeeCategory")
                        .WithMany("Employees")
                        .HasForeignKey("SubEmployeeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubEmployeeCategory");
                });

            modelBuilder.Entity("Domain.Entities.Post", b =>
                {
                    b.HasOne("Domain.Entities.PostCategory", "PostCategory")
                        .WithMany("Posts")
                        .HasForeignKey("PostCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PostCategory");
                });

            modelBuilder.Entity("Domain.Entities.Sector", b =>
                {
                    b.HasOne("Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Domain.Entities.SubEmployeeCategory", b =>
                {
                    b.HasOne("Domain.Entities.EmployeeCategory", "EmployeeCategory")
                        .WithMany("SubEmployeeCategories")
                        .HasForeignKey("EmployeeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeCategory");
                });

            modelBuilder.Entity("Domain.Entities.EmployeeCategory", b =>
                {
                    b.Navigation("SubEmployeeCategories");
                });

            modelBuilder.Entity("Domain.Entities.PostCategory", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Domain.Entities.SubEmployeeCategory", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
