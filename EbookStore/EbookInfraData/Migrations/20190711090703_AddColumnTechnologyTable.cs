using Microsoft.EntityFrameworkCore.Migrations;

namespace EbookInfraData.Migrations
{
    public partial class AddColumnTechnologyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TechnologyDomain",
                table: "Technology",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TechnologyDomain",
                table: "Technology");
        }
    }
}
