using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDay01.Migrations
{
    public partial class ChangeNameColumnInEmpModelToEmpName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Emps",
                newName: "EmpName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "Emps",
                newName: "Name");
        }
    }
}
