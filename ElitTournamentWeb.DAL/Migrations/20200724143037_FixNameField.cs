using Microsoft.EntityFrameworkCore.Migrations;

namespace ElitTournamentWeb.DAL.Migrations
{
    public partial class FixNameField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fileld",
                table: "Games",
                newName: "Field");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Field",
                table: "Games",
                newName: "Fileld");
        }
    }
}
