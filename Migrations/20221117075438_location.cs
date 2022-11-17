using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyDataBase.Migrations
{
    public partial class location : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentLocations",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentLocations", x => new { x.DepartmentId, x.Location });
                    table.ForeignKey(
                        name: "FK_DepartmentLocations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentLocations");
        }
    }
}
