using Microsoft.EntityFrameworkCore.Migrations;

namespace ElitTournamentWeb.DAL.Migrations
{
    public partial class FixId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SeasonId",
                table: "Rounds",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SeasonId",
                table: "Rounds",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
