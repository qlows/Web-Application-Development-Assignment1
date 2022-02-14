using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerManager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhone = table.Column<int>(type: "int", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerManager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncidentPage",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technician = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOpened = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateClosed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentPage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManageProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManageProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechnicianManager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnicianName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TechnicianEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicianPhone = table.Column<int>(type: "int", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicianManager", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerManager");

            migrationBuilder.DropTable(
                name: "IncidentPage");

            migrationBuilder.DropTable(
                name: "ManageProducts");

            migrationBuilder.DropTable(
                name: "TechnicianManager");
        }
    }
}
