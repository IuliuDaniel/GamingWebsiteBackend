using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamingWebsiteBE.Migrations
{
    public partial class GameTable_StructureUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MinimumRequirements",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecommendedRequirements",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinimumRequirements",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "RecommendedRequirements",
                table: "Games");
        }
    }
}
