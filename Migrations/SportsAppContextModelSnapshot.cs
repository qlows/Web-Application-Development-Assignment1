﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsApp.Data;

#nullable disable

namespace SportsApp.Migrations
{
    [DbContext(typeof(SportsAppContext))]
    partial class SportsAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SportsApp.Models.CustomerManager", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerPhone")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("CustomerPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerState")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerManager");
                });

            modelBuilder.Entity("SportsApp.Models.IncidentPage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technician")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncidentPage");
                });

            modelBuilder.Entity("SportsApp.Models.ManageProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ManageProducts");
                });

            modelBuilder.Entity("SportsApp.Models.TechnicianManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TechnicianEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechnicianName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("TechnicianPhone")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TechnicianManager");
                });
#pragma warning restore 612, 618
        }
    }
}
