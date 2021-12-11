using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam2.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country_id",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "department_id",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department_Name = table.Column<string>(nullable: true),
                    Minimum_Salary = table.Column<int>(nullable: false),
                    Maximum_Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_department_id",
                table: "Employees",
                column: "department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_department_id",
                table: "Employees",
                column: "department_id",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_department_id",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Employees_department_id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "department_id",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "Country_id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
