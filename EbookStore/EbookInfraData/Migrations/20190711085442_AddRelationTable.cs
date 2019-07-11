using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EbookInfraData.Migrations
{
    public partial class AddRelationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Book",
                newName: "BookName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Book",
                newName: "BookId");

            migrationBuilder.AddColumn<int>(
                name: "TechnologyId",
                table: "Book",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "BookId");

            migrationBuilder.CreateTable(
                name: "Technology",
                columns: table => new
                {
                    TechnologyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TechnologyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.TechnologyId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_TechnologyId",
                table: "Book",
                column: "TechnologyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Technology_TechnologyId",
                table: "Book",
                column: "TechnologyId",
                principalTable: "Technology",
                principalColumn: "TechnologyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Technology_TechnologyId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Technology");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_TechnologyId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "TechnologyId",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "Books",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Books",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");
        }
    }
}
