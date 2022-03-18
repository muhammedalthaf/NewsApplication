using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Newses_NewsId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_NewsId",
                table: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Newses",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Schools");

            migrationBuilder.RenameTable(
                name: "Newses",
                newName: "News");

            migrationBuilder.AddPrimaryKey(
                name: "PK_News",
                table: "News",
                column: "NewsId");

            migrationBuilder.CreateTable(
                name: "NewsSchool",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    SchoolsSchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsSchool", x => new { x.NewsId, x.SchoolsSchoolId });
                    table.ForeignKey(
                        name: "FK_NewsSchool_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsSchool_Schools_SchoolsSchoolId",
                        column: x => x.SchoolsSchoolId,
                        principalTable: "Schools",
                        principalColumn: "SchoolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsSchool_SchoolsSchoolId",
                table: "NewsSchool",
                column: "SchoolsSchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsSchool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_News",
                table: "News");

            migrationBuilder.RenameTable(
                name: "News",
                newName: "Newses");

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "Schools",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Newses",
                table: "Newses",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_NewsId",
                table: "Schools",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Newses_NewsId",
                table: "Schools",
                column: "NewsId",
                principalTable: "Newses",
                principalColumn: "NewsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
