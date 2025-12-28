using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPCORECRUDECODEFIRST.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EMP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_NAME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Emp_Age = table.Column<int>(type: "int", nullable: false),
                    EMP_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOJ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DESIGNATION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SALARY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EMP_ID);
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
