using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityApiBackend.Migrations
{
    public partial class CreateCursostable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "level",
                table: "Curso",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "level",
                table: "Curso");
        }
    }
}
