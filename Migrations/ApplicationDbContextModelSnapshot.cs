﻿// <auto-generated />
<<<<<<< HEAD
using System;
=======
>>>>>>> ae8cd0f98d5b7dd89cf8adc2ebd9ac2ff7a10ea7
using Employee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Employee.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Employee.Models.EmployeesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Address2")
<<<<<<< HEAD
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime(6)");
=======
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("longtext");
>>>>>>> ae8cd0f98d5b7dd89cf8adc2ebd9ac2ff7a10ea7

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Initials")
<<<<<<< HEAD
                        .HasColumnType("longtext");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");
=======
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");
>>>>>>> ae8cd0f98d5b7dd89cf8adc2ebd9ac2ff7a10ea7

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
