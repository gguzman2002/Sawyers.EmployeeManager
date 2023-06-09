﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sawyers.EmployeeManager.Data;

#nullable disable

namespace Sawyers.EmployeeManager.Migrations
{
    [DbContext(typeof(EmployeeManagerDbContext))]
    [Migration("20230322022741_Initializer")]
    partial class Initializer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sawyers.EmployeeManager.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Management"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Engineering"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("Sawyers.EmployeeManager.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            FirstName = "Michael",
                            IsDeveloper = false,
                            LastName = "Scott"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            FirstName = "Montgomery",
                            IsDeveloper = true,
                            LastName = "Scott"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 1,
                            FirstName = "James",
                            IsDeveloper = false,
                            LastName = "Kirk"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 2,
                            FirstName = "Qui-Gon",
                            IsDeveloper = true,
                            LastName = "Jinn"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 2,
                            FirstName = "Obi-Wan",
                            IsDeveloper = true,
                            LastName = "Kenobi"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 1,
                            FirstName = "Indiana",
                            IsDeveloper = true,
                            LastName = "Jones"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 4,
                            FirstName = "Toby",
                            IsDeveloper = false,
                            LastName = "Flenderson"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 5,
                            FirstName = "Kevin",
                            IsDeveloper = false,
                            LastName = "Flynn"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 3,
                            FirstName = "Spock",
                            IsDeveloper = false,
                            LastName = "Spock"
                        },
                        new
                        {
                            Id = 10,
                            DepartmentId = 5,
                            FirstName = "Forrest",
                            IsDeveloper = false,
                            LastName = "Gump"
                        });
                });

            modelBuilder.Entity("Sawyers.EmployeeManager.Data.Models.Employee", b =>
                {
                    b.HasOne("Sawyers.EmployeeManager.Data.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Sawyers.EmployeeManager.Data.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
