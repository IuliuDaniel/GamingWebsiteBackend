using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamingWebsiteBE.Migrations
{
    public partial class UpdateNewsTableStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArticleLink",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleLink",
                table: "News");
        }
    }
}
