using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class attachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewsAttachements",
                table: "News");

            migrationBuilder.CreateTable(
                name: "NewsAttachments",
                columns: table => new
                {
                    AttachmentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_NewsAttachments_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsAttachments_NewsId",
                table: "NewsAttachments",
                column: "NewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsAttachments");

            migrationBuilder.AddColumn<string>(
                name: "NewsAttachements",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
