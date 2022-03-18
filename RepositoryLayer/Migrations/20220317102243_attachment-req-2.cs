using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class attachmentreq2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewsAttachmentId",
                table: "NewsAttachments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsAttachments",
                table: "NewsAttachments",
                column: "NewsAttachmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsAttachments",
                table: "NewsAttachments");

            migrationBuilder.DropColumn(
                name: "NewsAttachmentId",
                table: "NewsAttachments");
        }
    }
}
