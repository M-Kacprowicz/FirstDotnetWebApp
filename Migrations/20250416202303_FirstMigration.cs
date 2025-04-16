using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstWebApp.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departament = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseSalary = table.Column<int>(type: "int", nullable: true),
                    MonthlyBonus = table.Column<double>(type: "float(16)", precision: 16, scale: 2, nullable: true),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BaseSalary", "CreatedAtUtc", "Departament", "MonthlyBonus", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("16fa4b45-518f-4da5-91f3-6b9b1a524ca3"), 4000, new DateTime(2025, 4, 16, 20, 23, 2, 582, DateTimeKind.Utc).AddTicks(7797), "Engineering", 120.0, "Paweł", "Janusz" },
                    { new Guid("2f4b52f8-0823-42d9-97a2-28839865a3cd"), 3000, new DateTime(2025, 4, 16, 20, 23, 2, 582, DateTimeKind.Utc).AddTicks(7795), "Maintenance", 150.0, "Andrzej", "Kowalski" },
                    { new Guid("81a30b7a-4463-4cab-ac5e-fa987a9c1dff"), 4500, new DateTime(2025, 4, 16, 20, 23, 2, 582, DateTimeKind.Utc).AddTicks(7798), "HR", 50.0, "Joanna", "Niewiadoma" },
                    { new Guid("a7e7dcc7-9e08-41e5-8de2-cec69e2018a7"), 5000, new DateTime(2025, 4, 16, 20, 23, 2, 582, DateTimeKind.Utc).AddTicks(7792), "IT", 100.0, "Jan", "Kowalski" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
