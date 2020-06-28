using Microsoft.EntityFrameworkCore.Migrations;

namespace ElitTournamentWeb.DAL.Migrations
{
    public partial class RemoveEditModeFromPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditMode",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EditMode",
                table: "Posts",
                nullable: false,
                defaultValue: false);
        }
    }
}
