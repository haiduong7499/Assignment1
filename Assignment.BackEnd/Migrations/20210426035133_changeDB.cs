using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.BackEnd.Migrations
{
    public partial class changeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rated",
                table: "Products",
                newName: "Rate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Products",
                newName: "Rated");
        }
    }
}
