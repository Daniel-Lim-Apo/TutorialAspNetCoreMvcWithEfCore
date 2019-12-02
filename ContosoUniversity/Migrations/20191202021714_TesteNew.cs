using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class TesteNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "LastName",
            //    table: "Student",
            //    newName: "FirstNameNew");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "LastName",
            //    table: "Student",
            //    newName: "FirstName");
        }
    }
}
