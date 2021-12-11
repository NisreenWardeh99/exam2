using Microsoft.EntityFrameworkCore.Migrations;

namespace Exam2.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "Country_id",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Country_id",
                table: "Employees",
                column: "Country_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Countries_Country_id",
                table: "Employees",
                column: "Country_id",
                principalTable: "Countries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Countries_Country_id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Country_id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Country_id",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
