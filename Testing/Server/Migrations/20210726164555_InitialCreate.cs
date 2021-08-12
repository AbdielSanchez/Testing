using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Testing.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentID1",
                        column: x => x.DepartmentID1,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "SD" },
                    { 2, "A" },
                    { 3, "B" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "BirthDate", "DepartmentID", "DepartmentID1", "Gender", "LastName", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", null, 1, "Smith", "Sam" },
                    { 2, new DateTime(1996, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, 0, "Fuentes", "Andrés" },
                    { 3, new DateTime(2007, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", null, 0, "Hatsune", "Miku" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID1",
                table: "Employees",
                column: "DepartmentID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
