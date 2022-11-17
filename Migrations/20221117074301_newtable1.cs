using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyDataBase.Migrations
{
    public partial class newtable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId1",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId1",
                table: "Departments",
                column: "ManagerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_ManagerId1",
                table: "Departments",
                column: "ManagerId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_ManagerId1",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerId1",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ManagerId1",
                table: "Departments");
        }
    }
}
